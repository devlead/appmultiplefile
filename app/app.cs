#:sdk Cake.Sdk@5.0.25253.70-beta
#:property IncludeAdditionalFiles=../models/**/*.cs;../utils/**/*.cs
using Models;
using static Utils.PetUtils;

Pet[] pets = [
                new Dog { Name = "Fido" },
                new Cat { Name = "Whiskers" }
            ];

MakeAllPetsSound(pets);