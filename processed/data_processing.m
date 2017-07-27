% User inputs
% -----------

file_name='testFIX -long';
file_extension='txt';

% skip the first 'i_skip' samples; may be dirty data for whatever reason (e.g., user adjusting headset)

i_skip=0;


% Pre-Processor (i.e., prepare data)
% -------------

% load data

filename=strcat(file_name,'.',file_extension);
varname = dlmread(filename,',',i_skip,0);

time=varname(:,1);
xc=varname(:,2);
yc=varname(:,3);

clear varname;

% scale time from miliseconds to seconds

time=time*1.0e-3;

% find the sampling rate (assumes no lapses in data sampling)
% dt_vec is the incremental time, which should be approx. constant if there are no lapses in the data sampling

dt_vec=diff(time);
sample_dt=mean(dt_vec);
Fs=round(1.0/sample_dt);

% re-create the time vector, now with a uniform sampling rate.  Start time at t=0s

clear time;
clear sample_dt;

sample_dt=1.0/Fs;
t_min=0.0;
t_max=sample_dt*(length(xc)-1);
time=[t_min:sample_dt:t_max]';

sample_time=(t_max-t_min)/60.0;

% flip the y-coordinate so that (xc,yc) aligns with the measurement reference coordinate system

yc=-yc;

disp(['Eye Tracker Data Analysis'])
disp(['*************************'])
disp(['by Nicole Pontaza'])
disp(['UIUC 2017'])
disp([' '])
disp(['Sample time   (min): ', num2str(sample_time)])
disp(['Time interval (sec): ', num2str(t_min),' , ', num2str(t_max)])
disp([' '])
disp(['Sampling time interval(sec): ', num2str(sample_dt)])
disp(['Sampling frequency     (Hz): ', num2str(Fs)])

% Processor (i.e., visualize data to see trends)
% ---------

xc_mean=mean(xc);
xc_max=max(xc);
xc_min=min(xc);

yc_mean=mean(yc);
yc_max=max(yc);
yc_min=min(yc);

disp([' '])
disp(['Mean X               (-): ', num2str(xc_mean)])
disp(['Standard deviation X (-): ', num2str(std(xc))])
disp(['Max and Min X        (-): ', num2str(xc_max),' , ', num2str(xc_min)])
disp(['Peak-to-peak X       (-): ', num2str(xc_max-xc_min)])
disp([' '])

disp([' '])
disp(['Mean Y               (-): ', num2str(yc_mean)])
disp(['Standard deviation Y (-): ', num2str(std(yc))])
disp(['Max and Min Y        (-): ', num2str(yc_max),' , ', num2str(yc_min)])
disp(['Peak-to-peak Y       (-): ', num2str(yc_max-yc_min)])
disp([' '])


figure(1)
plot(xc,yc)
xlabel('X-coordinate, mm','fontsize',20);
ylabel('Y-coordinate, mm','fontsize',14);
title('X-Y Eye Movement','fontsize',16)
set(gca,'fontsize',12)
hold on;

plot(xc_mean,yc_mean,'x','LineWidth',2,'MarkerSize',10,'MarkerEdgeColor','r')

h_legend=legend('Data','Mean Eye Position','Location','SouthEast');
set(h_legend,'FontSize',10);


figure(2)
plot(time,xc,'Color','b','LineWidth',1.25)
xlabel('time, sec','fontsize',20);
ylabel('X-coordinate, mm','fontsize',14);
title('Horizontal Eye Movement in Time','fontsize',16)
set(gca,'fontsize',12)


figure(3)
plot(time,yc,'Color','g','LineWidth',1.25)
xlabel('time, sec','fontsize',20);
ylabel('Y-coordinate, mm','fontsize',14);
title('Vertical Eye Movement in Time','fontsize',16)
set(gca,'fontsize',12)


% Advanced signal processing: Power Spectral Density (PSD) curves
% This shows the eye movement energy as a function of frequency
% The plot is in a LOG-LOG scale

xcd=detrend(xc);
ycd=detrend(yc);
win_size_dt=2.0;

N=length(xc);
N_fft=2^nextpow2(N);
wi=round(win_size_dt/sample_dt);

[Puu,f]=pwelch(xc,wi,[],N_fft,Fs);
[Pvv,f]=pwelch(yc,wi,[],N_fft,Fs);

figure(4)
loglog(f,Puu,'LineWidth',1.5)
xlabel('frequency, Hz','fontsize',12);
ylabel('PSD, (units)^2/Hz','fontsize',12);
title('Eye Movement PSDs','fontsize',12)
set(gca,'fontsize',12)
xlim([0.1 20]);
hold on;

loglog(f,Pvv,'LineWidth',1.5)

h_legend=legend('X-Data','Y-Data','Location','NorthEast');
set(h_legend,'FontSize',10);

% clean-up the workspace
% ommit this command in case you want to keep all the variables used in this command file on your workspace

clear;
