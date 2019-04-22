#ifndef SAVETOCLOUDCONFIG_H
#define SAVETOCLOUDCONFIG_H

#include <string>
#include <iostream>
class SaveToCloudConfig
{
public:
    struct JSON{
        std::string config;
        int size;
    };

    void writeData(JSON config){
        std::cout << config.size <<" "<< config.config << std::endl;
    }
};

#endif // SAVETOCLOUDCONFIG_H
