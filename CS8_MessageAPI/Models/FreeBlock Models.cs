namespace CS8_MessageAPI.Models;

public record Block(
    string blockId,
    string name,
    string schoolLevel);
    
public record FreeBlock(
    DateTime start,
    DateTime end,
    Block block); 

public  record FreeBlockCollection(
    FreeBlock [] freeBlocks,
    DateOnly [] inRange);