// See https://aka.ms/new-console-template for more information
using FactoryMethod;

AppleCreator appleCreator = new AppleCreator();
BananaCreator bananaCreator = new BananaCreator();
OrangeCreator orangeCreator = new OrangeCreator();

IFruit apple = appleCreator.FactoryMethod();
IFruit banana = bananaCreator.FactoryMethod();
IFruit orange = orangeCreator.FactoryMethod();

apple.WhoAmI();
banana.WhoAmI();
orange.WhoAmI();
