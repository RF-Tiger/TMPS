#ifndef ENCRYPTEDDATA_H
#define ENCRYPTEDDATA_H

#include "linuxconfigmanager.h"
class EncryptedData: public LinuxConfigManager
{
    ConfigManager *base;
public:
    EncryptedData(ConfigManager *base):
    base(base){}
    void writeData(std::string data){
        data += " encrypted";
        base->writeData(data);
    }


};

#endif // ENCRYPTEDDATA_H
