#ifndef DEFAULTCONFIG_H
#define DEFAULTCONFIG_H

#include "configmanager.h"
class DefaultConfig
{
    ConfigManager *manager;
public:
    DefaultConfig(ConfigManager *manager)
        :manager(manager){}
    void setLinuxDefaultConfig(){
        manager->openConfigFile();
        manager->writeData("linux default data");
        manager->closeConfigFile();
    }
    void setWindowsDefaultConfig(){
        manager->openRegistry();
        manager->writeData("windows default data");
        manager->closeRegistry();
    }
};

#endif // DEFAULTCONFIG_H
