package temp;
import java.io.File;
import java.util.*;

class Cricketers {
    public String Name;
    Cricketers(String n){
        this.Name = n;
    }

    @Override
    public String toString() {
        return Name;
    }
}

public class BlockingQueue
{
    private List queue = new LinkedList();
    private int limit = 10;

    public BlockingQueue(int limit)
    {
        this.limit = limit;
    }
    public synchronized void enqueue(Object temp)
            throws InterruptedException
    {
        while (this.queue.size() == this.limit) {
            wait();
        }
        if (this.queue.size() == 0) {
            notifyAll();
        }
        this.queue.add(temp.toString());
    }

    public synchronized Object dequeue()
            throws InterruptedException
    {
        while (this.queue.size() == 0) {
            wait();
        }
        if (this.queue.size() == this.limit) {
            notifyAll();
        }

        return this.queue.remove(0);
    }

    public static void main(String[] args) throws InterruptedException {
        int cap = 3;
        BlockingQueue q = new BlockingQueue(cap);

        q.enqueue(new Cricketers("Virat"));
        q.enqueue(new Cricketers("Rohit"));
        q.enqueue(new Cricketers("Rahul"));
        System.out.println(q.dequeue());
        q.enqueue(new Cricketers("Hardik"));


        System.out.println(q.dequeue());
        System.out.println(q.dequeue());
        System.out.println(q.dequeue());



    }
    }
