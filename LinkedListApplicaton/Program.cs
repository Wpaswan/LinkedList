using LinkedListApplicaton;
//LinkedList list = new LinkedList();
//list.Add(56);
////list.Add(30);
//list.Add(70);
//list.InsertAtParticularPosition(2, 30);
LinkedList list2 = new LinkedList();
//Appends the Nodes
list2.AddFirst(56);
list2.AddFirst(30);
list2.AddFirst(70);

//Remove first node 50 from the linked list
list2.RemoveFirstNode();
list2.Display();
//Removed Last Node 70 from the linked list
Console.WriteLine("Removed the last node from the linked list");
LinkedList list5 = new LinkedList();
list5.Add(56);
list5.Add(30);
list5.Add(70);
list5.RemovaLastNode();
list5.Display();
//Search Node 30 from the given liked list
Console.WriteLine("Searching the Nodes");
LinkedList list6 = new LinkedList();
list6.Add(56);
list6.Add(30);
list6.Add(70);
list6.Search(30);
list6.Display();
Console.ReadKey();


