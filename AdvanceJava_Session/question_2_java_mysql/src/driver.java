import java.sql.*;
import org.dom4j.io.SAXReader;
import org.dom4j.*;
import java.io.File;
import java.util.*;



// Notice, do not import com.mysql.jdbc.*
// or you will have problems!

public class driver {

    private static final String CREATE_TABLE_SQL="CREATE TABLE dbone.student ("
            + "ID INT NOT NULL PRIMARY KEY,"
            + "NAME VARCHAR(50),"
            + "SURNAME VARCHAR(50),"
            + "GENDER VARCHAR(45) NOT NULL,"
            + "MARKS FLOAT)";

    public static void addRow(Connection con,int Id, String FirstName, String MiddleName, String LastName,String Gender, float Marks)
    {
        try {

            PreparedStatement stmt = con.prepareStatement("insert into student values (?,?,?,?,?)");
            stmt.setInt(1, Id);
            stmt.setString(2, FirstName+" "+MiddleName);
            stmt.setString(3, LastName);
            stmt.setString(4, Gender);
            stmt.setFloat(5, Marks);
            if(stmt.executeUpdate()>0)
                System.out.println("Student Record Inserted\n");
            else
                System.out.println("Insertion Failed");

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    public static void main(String[] args) {
        String jdbcUrl = "jdbc:mysql://localhost/?user=root";
        String username = "root";
        Connection conn = null;
        Statement stmt = null;

        String FirstName=null;
        String MiddleName=null;
        String LastName=null;
        String Gender=null;
        int RollNo=0;
        float Marks=0;
        try {

            conn = DriverManager.getConnection(jdbcUrl);
            stmt = conn.createStatement();

            stmt.executeUpdate(CREATE_TABLE_SQL);
            stmt.executeUpdate("use dbone;");

            System.out.println("Table created");

            File xmlfile = new File("XML/input.txt");
            SAXReader saxReader = new SAXReader();
            Document document = saxReader.read(xmlfile);
            List<Node> nodes = document.selectNodes("/class/student");

            for (Node node : nodes) {
                RollNo = Integer.parseInt(node.valueOf("@rollno"));
                FirstName = node.selectSingleNode("name/firstname").getText();
                MiddleName = node.selectSingleNode("name/middlename").getText();
                LastName = node.selectSingleNode("name/lastname").getText();
                Gender = node.selectSingleNode("gender").getText();
                Marks = Float.parseFloat(node.selectSingleNode("marks").getText());
            }
            addRow(conn,RollNo,FirstName,MiddleName,LastName,Gender,Marks);
            System.out.println("Table filled");


        } catch (SQLException | DocumentException e) {
            e.printStackTrace();
        }finally {
            try {
                // Close connection
                if (stmt != null) {
                    stmt.close();
                }
                if (conn != null) {
                    conn.close();
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

    }
}