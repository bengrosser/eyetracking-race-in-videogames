file_name = "30 min fixation - Rescuing Eliz"
file_extension = ".txt"
%Load data
filename=strcat(file_name,'.',file_extension);
varname = dlmread(filename,',');

time = varname(:,1);
xc = varname(:,2);
yc = varname(:,3);

clear varname;

% scale time from miliseconds to seconds

time=time*1.0e-3;

