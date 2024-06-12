public class Main {
    public static void main(String[] args) {
        StopThread stopThread = new StopThread();


        for(int i=1;i<=5;i++)
        {
            new SumThread(i, stopThread, 1).start();
        }

        new Thread(stopThread).start();
    }
}