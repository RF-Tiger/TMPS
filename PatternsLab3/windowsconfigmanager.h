#ifndef WINDOWSCONFIGMANAGER_H
#define WINDOWSCONFIGMANAGER_H

#include "configmanager.h"
#include <iostream>

class WindowsConfigManager: public ConfigManager
{
protected:
    WriteStrategy *strategy;
public:
    WindowsConfigManager(WriteStrategy *strategy):
        strategy(strategy){}
    void openRegistry(){
        std::cout << "Open Registry"<< std::endl;
    }
    void closeRegistry(){
        std::cout << "Close Registry"<< std::endl;
    }
    void readData(){
        std::cout << "Read Registry"<< std::endl;
    }

    void writeData(std::string data){
        strategy->execute(data);
    }
    ~WindowsConfigManager(){}
};

#endif // WINDOWSCONFIGMANAGER_H
