import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;


public class TestmockTestSolution {

	@Test
	void test1() {
		Solution sol = new Solution();
		int[] answers = {1,2,3,4,5};
		int[] expected = {1};
		
		int[] actual = sol.mockTest(answers);
		
		Assertions.assertArrayEquals(expected, actual);		
	}
	
	@Test
	void test2() {
		Solution sol = new Solution();
		int[] answers = {1,3,2,4,2};
		int[] expected = {1,2,3};
		
		int[] actual = sol.mockTest(answers);
		
		Assertions.assertArrayEquals(expected, actual);		
	}

}
