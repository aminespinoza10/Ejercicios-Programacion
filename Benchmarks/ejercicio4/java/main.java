import java.util.ArrayList;
import java.util.List;

class DataItem {
    int x;
    String y;
    
    DataItem(int x, String y) {
        this.x = x;
        this.y = y;
    }
}

public class main {
    public static void main(String[] args) {
        long startTime = System.nanoTime();

        List<DataItem> data = new ArrayList<>();
        for (int i = 0; i < 2_000_000; i++)
            data.add(new DataItem(i, String.valueOf(i)));

        StringBuilder sb = new StringBuilder();
        sb.append("[");
        for (int i = 0; i < data.size(); i++) {
            DataItem item = data.get(i);
            if (i > 0) sb.append(",");
            sb.append("{\"x\":").append(item.x).append(",\"y\":\"").append(item.y).append("\"}");
        }
        sb.append("]");
        String s = sb.toString();
        
        // Simple deserialization simulation (just parse to verify)
        int count = 0;
        for (char c : s.toCharArray()) {
            if (c == '{') count++;
        }

        long endTime = System.nanoTime();
        double elapsed = (endTime - startTime) / 1_000_000_000.0;
        System.out.printf("Time: %.4f seconds%n", elapsed);
        System.out.println("Items processed: " + data.size());
        System.out.println("JSON size: " + s.length() + " bytes");
    }
}
