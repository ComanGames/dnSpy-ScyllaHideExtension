filePub = open('PubParam.txt','r');
filePriv = open('PrivParam.txt','r');

PubLines = [l.rstrip('\n') for l in filePub.readlines()]
PrivLines = [l.rstrip('\n') for l in filePriv.readlines()]
AllLines = PubLines + PrivLines;
filePub.close();
filePriv.close();


def CreateGetSet(lines):
    for line in lines:
        print('						public bool %s' % (line))
        print('						{')
        print('						get { return settings.CurrentSelectedSection.%s; } ' % (line))
        print('						set')
        print('						{')
        print('				        if (settings.CurrentSelectedSection.%s != value) {' % (line))
        print('				        settings.CurrentSelectedSection.%s = value; ' % (line))
        print('				       	OnPropertyChanged(nameof(%s));' % (line))
        print('				       	OnModefied();')
        print('						}')
        print('						}')
        print('						}')
        print('						')
    return;

def CreateXamlLines(lines):
    i = 0;
    for line in PrivLines:
        i=i+1;
        x = 210+(i*20);
        print('        <CheckBox Content="%s" HorizontalAlignment="Left" Margin="400,%d,0,0" VerticalAlignment="Top" Width="148" IsChecked="{Binding %s}"/>' % (line,x,line))
    return;

def CreateIniRead(lines):
    for line in lines:
        print('			%s = file.Read("%s", SectionName)=="1";' % (line,line));
    return;

def CreateIniWrite(lines):
    for line in lines:
        print('			file.Write("%s", BoolToStr(%s), SectionName);' % (line,line));
    return;

def CreateOnPropertyChanged(lines):
    for line in lines:
        print('			OnPropertyChanged(nameof(%s));' % line);
    return; 

def CreatePublicVar(lines):
    for line in lines:
        print('					public bool %s;' % line);
    return; 

