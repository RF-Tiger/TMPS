#ifndef CONFIGTOJSONADAPTER_H
#define CONFIGTOJSONADAPTER_H

#include "linuxconfigmanager.h"
#include "savetocloudconfig.h"
class ConfigToJSONAdapter:LinuxConfigManager
{
    SaveToCloudConfig *stcc;
public:
    ConfigToJSONAdapter(SaveToCloudConfig *stcc):
        stcc(stcc){}
    void writeData(std::string data){
        SaveToCloudConfig::JSON json;
        json.config = data;
        json.size = data.size();
        stcc->writeData(json);
    }
};

#endif // CONFIGTOJSONADAPTER_H
