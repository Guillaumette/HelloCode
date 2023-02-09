marker:
    Console.Write("Введите значение изначального расстояния: ");
    int TotalDistance = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение скорости первого друга: ");
    int FirstFriendSpeed = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение скорости второго друга: ");
    int SecondFriendSpeed = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение скорости собаки: ");
    int DogSpeed = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение расстояния точки встречи: ");
    int MeetPoint = Convert.ToInt32(Console.ReadLine());;

    if (MeetPoint > TotalDistance)
    {
        Console.WriteLine("Значение общего расстояния должно быть больше значения точки встречи");
         goto marker;
    }

    if (MeetPoint == 0)
    {
        Console.WriteLine("Введите значение больше нуля");
        goto marker;
    }

    int count = 0;
    bool friend = true; // переменная-флаг, чтобы определять, от кого к кому бежит собака в данный момент
    int time = 0; // переменная времени, за которое собака пробегает один раз
    while(TotalDistance > MeetPoint)
    {
        if(friend == true)
        {
            time = TotalDistance / (SecondFriendSpeed + DogSpeed);
            friend = false;
        }
        else
        {
            time = TotalDistance / (FirstFriendSpeed + DogSpeed);
            friend = true;
        }
        TotalDistance = TotalDistance - (FirstFriendSpeed + SecondFriendSpeed) * time;
        count++;
        }

Console.WriteLine($"Собака пробежит {count} раз");