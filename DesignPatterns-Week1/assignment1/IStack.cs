using System;

namespace assignment1;

public interface IStack
{
void Push(int value);
int Pop();
bool Contains(int value);
int Count { get; }
bool IsEmpty { get; }
}
