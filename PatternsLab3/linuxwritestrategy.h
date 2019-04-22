#ifndef LINUXWRITESTRATEGY_H
#define LINUXWRITESTRATEGY_H

#include "writestrategy.h"
#include <iostream>
class LinuxWriteStrategy: public WriteStrategy{
    void execute(std::string data){
        std::cout << "Linux Write "<< data << std::endl;
    }
    ~LinuxWriteStrategy(){}
};
#endif // LINUXWRITESTRATEGY_H
