import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

import junit.framework.Assert;

class TestHarsaNumber {

	@Test
	void testNum10() {
		Solution test = new Solution();
		int x = 10;
		boolean expected = true;
		
		boolean actual = test.HarsaNumber(x);
		
		Assert.assertEquals(expected, actual);
	}
	
	@Test
	void testNum12() {
		Solution test = new Solution();
		int x = 12;
		boolean expected = true;
		
		boolean actual = test.HarsaNumber(x);
		
		Assert.assertEquals(expected, actual);
	}
	
	@Test
	void testNum13() {
		Solution test = new Solution();
		int x = 13;
		boolean expected = false;
		
		boolean actual = test.HarsaNumber(x);
		
		Assert.assertEquals(expected, actual);
	}
	
	@Test
	void testNum16() {
		Solution test = new Solution();
		int x = 16;
		boolean expected = false;
		
		boolean actual = test.HarsaNumber(x);
		
		Assert.assertEquals(expected, actual);
	}

}
