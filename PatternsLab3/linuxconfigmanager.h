#ifndef LINUXCONFIGMANAGER_H
#define LINUXCONFIGMANAGER_H

#include "configmanager.h"
#include <iostream>
class LinuxConfigManager: public ConfigManager
{
protected:
    WriteStrategy *strategy;
public:    
    void openConfigFile(){
        std::cout << "Open Config File"<< std::endl;
    }
    void writeData(std::string data){
         strategy->execute(data);
    }
    void setStrategy(WriteStrategy *strategy){
        this->strategy = strategy;
    }
    void readData(){
        std::cout << "Read Config File"<< std::endl;
    }

    void closeConfigFile(){
        std::cout << "Close Config File"<< std::endl;
    }
    ~LinuxConfigManager(){}
};

#endif // LINUXCONFIGMANAGER_H
