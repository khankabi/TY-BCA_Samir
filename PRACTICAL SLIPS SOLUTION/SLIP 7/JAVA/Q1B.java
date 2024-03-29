
// Write a java program to accept details of ‘n’ cricket player (pid, pname, totalRuns, InningsPlayed, NotOuttimes). Calculate the average of all the players.
//  Display the details of player having maximum average. (Use Array of Object)
import java.io.*;

class CricketPlayer {
    int pcode, run, notout;
    String name;
    int iplayed;

    CricketPlayer(int pcode1, String pname, int run1, int iplayed1, int notout1) throws IOException {
        pcode = pcode1;
        name = pname;
        run = run1;
        iplayed = iplayed1;
        notout = notout1;
    }

    public double average(String name1) {
        double avg = 0;
        if (name.equals(name1)) {
            avg = (double) run / (double) iplayed;
            return avg;
        } else
            return 0;
    }

    public double average() {
        double avg = 0;
        avg += (double) run / (double) iplayed;
        return avg;
    }
}

class Q1B

{
    public static void main(String args[]) throws IOException {
        int pcode, iplayed, noplayer, notout, runs;
        double avg = 0, avgall = 0;
        String name;
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("“Enter How many Players:=> “");
        noplayer = Integer.parseInt(br.readLine());
        CricketPlayer s[] = new CricketPlayer[noplayer];

        for (int i = 0; i < noplayer; i++) {
            System.out.println("“Enter Player Code:=> “");
            pcode = Integer.parseInt(br.readLine());
            System.out.println("“Enter Player Name:=> “");
            name = br.readLine();
            System.out.println("“Enter Runs:=> “");
            runs = Integer.parseInt(br.readLine());
            System.out.println("“Enter No of innings Played:=> “");
            iplayed = Integer.parseInt(br.readLine());
            System.out.println("“Enter No of Times Not Out:=> “");
            notout = Integer.parseInt(br.readLine());
            s[i] = new CricketPlayer(pcode, name, runs, iplayed, notout);
        }

        for (int i = 0; i < noplayer; i++) {
            avg += s[i].average("“Ram”");
        }

        System.out.println("“Average of Ram is :> “" + avg);

        for (int i = 0; i < noplayer; i++) {
            avgall = s[i].average();
            System.out.println("“Average of “" + s[i].name + " is :>”" + avgall);
        }
    }
}