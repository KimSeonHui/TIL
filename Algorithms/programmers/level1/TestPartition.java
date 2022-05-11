import org.junit.Assert;
import org.junit.jupiter.api.Test;

public class TestPartition {
	
	@Test
	public void testPartition1() {
		//given
		int[] S = {15, 22, 13, 27, 12, 10, 20, 25};
		int[] expected = {13, 12, 10, 15, 22, 27, 20, 25};
		Solution sol = new Solution();
		
		//when
		int[] actual = sol.partition1(0, 7, S);
		
		//then
		Assert.assertArrayEquals(expected, actual);
	}	
	
	@Test
	public void testParition2() {
		//given
		int[] S = {15, 22, 13, 27, 12, 10, 20, 25};
		int[] expected = {13, 12, 10, 15, 25, 20, 27, 22};
		Solution sol = new Solution();
		
		//when
		int[] actual = sol.partition2(0, 7, S);
		
		//then
		Assert.assertArrayEquals(expected, actual);
	}
}
