#include "windowsconfigmanager.h"
#include "windowswritestrategy.h"
#include "linuxconfigmanager.h"
#include "linuxwritestrategy.h"
#include "encrypteddata.h"
#include "defaultconfig.h"
#include "configtojsonadapter.h"
#include "savetocloudconfig.h"
int main(int argc, char *argv[])
{
    LinuxWriteStrategy *linuxStrategy = new LinuxWriteStrategy();
    WindowsWriteStrategy *windowsStrategy = new WindowsWriteStrategy();
    LinuxConfigManager *linuxConfig = new LinuxConfigManager();
     EncryptedData *encrypt = new EncryptedData(linuxConfig);
    linuxConfig->setStrategy(linuxStrategy);
    WindowsConfigManager *windowsConfig = new WindowsConfigManager(windowsStrategy);
    linuxConfig->openConfigFile();
    linuxConfig->writeData("some data for linux");
    encrypt->writeData("some data for linux");
    linuxConfig->closeConfigFile();

    windowsConfig->openRegistry();
    windowsConfig->writeData("some data for windows");
    windowsConfig->closeRegistry();

    DefaultConfig *dc = new DefaultConfig(linuxConfig);
    dc->setLinuxDefaultConfig();

    SaveToCloudConfig *clConf = new SaveToCloudConfig();
    ConfigToJSONAdapter *adapter = new ConfigToJSONAdapter(clConf);
    adapter->writeData("data to cloud");

}
