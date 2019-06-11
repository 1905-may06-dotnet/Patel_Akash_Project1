FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS buildDomain
WORKDIR /Patel_Akash_Project1
COPY Pizzabox.domain/ ../Pizzabox.domain
RUN dotnet build ../Pizzabox.domain/

COPY Pizzabox.data/ ../Pizzabox.data
RUN dotnet build ../Pizzabox.data

COPY PizzaWebsite/ ../PizzaWebsite
RUN dotnet build ../PizzaWebsite

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS deploy
WORKDIR /Patel_Akash_Project1/
COPY out/ /Patel_Akash_Project1/
CMD [ "dotnet", "PizzaWebsite.dll" ]

#it worked!!!
#http://192.168.99.100:9000 is the link for the thingy
#commands i used were docker build -t akashdocker .
#then I did docker run -p 9000:80 akashdocker