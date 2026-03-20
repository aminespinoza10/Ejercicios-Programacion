import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;

public class main {
    public static void main(String[] args) {
        try {
            long startTime = System.nanoTime();

            HttpClient client = HttpClient.newHttpClient();
            HttpRequest request = HttpRequest.newBuilder()
                .uri(URI.create("https://api.api-ninjas.com/v1/etf?ticker=SPY"))
                .header("X-Api-Key", "kRa7NM9a8mXTcgSoB7hFJBGZNayCZurnZkIqc1Cq")
                .GET()
                .build();

            HttpResponse<String> response = client.send(request, HttpResponse.BodyHandlers.ofString());

            long endTime = System.nanoTime();
            double elapsed = (endTime - startTime) / 1_000_000_000.0;

            System.out.printf("Time: %.4f seconds%n", elapsed);
            System.out.println("Status: " + response.statusCode());
            System.out.println("Response size: " + response.body().length() + " bytes");
            System.out.println("\nResponse body:");
            System.out.println(response.body());
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
            e.printStackTrace();
        }
    }
}
