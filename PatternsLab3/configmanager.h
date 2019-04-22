#ifndef CONFIGMANAGER_H
#define CONFIGMANAGER_H

#include <string>
#include "writestrategy.h"
class ConfigManager
{
public:
    virtual void openRegistry() {}
    virtual void openConfigFile() {}
    virtual void closeRegistry() {}
    virtual void closeConfigFile() {}
    virtual void writeData(std::string data) = 0;
    virtual void readData() = 0;
    virtual ~ConfigManager(){}
};

#endif // CONFIGMANAGER_H
