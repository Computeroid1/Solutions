class Lasagna
{
public int ExpectedMinutesInOven() {
    return 40;
}

public int RemainingMinutesInOven(int time){
    return 40 - time;
    }

public int PreparationTimeInMinutes(int layer){
    return 2 * layer;
}

public int ElapsedTimeInMinutes(int layer, int time){
    return (layer * 2) + (time);
}
}
