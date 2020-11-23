import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

import junit.framework.Assert;

class TestFindKimSolution {

	@Test
	void test() {
		
		Solution test = new Solution();
		String[] seoul = {"Jane", "Kim"};
		String expected = "�輭���� " + 1 + "�� �ִ�";
		
		String actual = test.FindKimSolution(seoul);
		
		Assert.assertEquals(expected, actual);
	}

}
