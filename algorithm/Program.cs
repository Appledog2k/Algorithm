// See https://aka.ms/new-console-template for more information
using singleLinkerList;

Console.WriteLine("Hello, World!");

singleLinkerList.Node head = new Node(1);
singleLinkerList.Node second = new Node(2);
singleLinkerList.Node third = new Node(3);

//* liên kết các phần tử
head.next = second;
second.next = third;

//* truy cập phần tử
//* head
int data = head.data;
Console.WriteLine("data: " + data);

//* duyệt tất cả
singleLinkerList.Node p = head;
while (p != null)
{
    data = p.data;
    p = p.next;
    Console.Write(data + "->");
}




