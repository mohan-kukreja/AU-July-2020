/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
import java.util.HashMap;
import java.util.Map;
import java.util.*;

public class Main

{
    public static void useMap(ArrayList<String> para)
    {
       
        Map<String, Integer> m = new HashMap<String, Integer>();

        for (String i : para) {
            Integer j = m.get(i);
            m.put(i, (j == null) ? 1 : j + 1);
        }

       
        for (Map.Entry<String,Integer> entry : m.entrySet())  
            System.out.println("Key = " + entry.getKey() + 
                             ", Value = " + entry.getValue());
        }
    
	public static void main(String[] args) {
		
        ArrayList<String> Paragraph = new ArrayList<String>();
        Paragraph.add("z");
        Paragraph.add("x");
        Paragraph.add("z");
        Paragraph.add("y");
        Paragraph.add("z");
        Paragraph.add("x");
        Paragraph.add("c");
        Paragraph.add("c");
        Paragraph.add("c");
        Paragraph.add("b");
        Paragraph.add("x");
       
        useMap(Paragraph);
	}
}
