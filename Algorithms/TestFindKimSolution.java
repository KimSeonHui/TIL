import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

import junit.framework.Assert;

class TestFindKimSolution {

	@Test
	void test() {
		
		Solution test = new Solution();
		String[] seoul = {"Jane", "Kim"};
		String expected = "김서방은 " + 1 + "에 있다";
		
		String actual = test.FindKimSolution(seoul);
		
		Assert.assertEquals(expected, actual);
	}

}
