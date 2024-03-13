#include <iostream>
class animal {
    public:
    void eat(){
        std::cout <<"I can eat!" <<std::endl;
    }
    void sleep(){
        std::cout <<"I can sleep!" <<std::endl;
    }
    void mate(){
        std::cout <<"I can fuck!" <<std::endl;
    }
};
class mammal : public animal {
    public:
    void speak(){
        std::cout <<"I can speak" <<std::endl;
    }
    void fight(){
        std::cout <<"I can fight!" <<std::endl;
    }
};
class birds : public animal {
    public:
    void fly(){
        std::cout <<"I can fly!" <<std::endl;
    }
    void nest(){
        std::cout <<"I can nest!" <<std::endl;
    }
};
    class reptiles : public animal {
    public:
    void lay_eggs(){
        std::cout <<"I can lay eggs!" <<std::endl;
    }
    void swim(){
        std::cout <<"I can swim!" <<std::endl;
    }
    };
int main(){
    mammal human;
    reptiles fish;
    birds eagles;
    human.speak();
    human.fight();
    fish.swim();
    fish.lay_eggs();
    eagles.fly();
    eagles.nest();
    human,fish,eagles.eat();
    human,fish,eagles.sleep();
    human,fish,eagles.mate();
    return 0;
}