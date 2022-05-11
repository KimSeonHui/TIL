import java.util.ArrayList;


public class Partition {
	public static void main(String arg[]) {
		Solution sol = new Solution();
		int[] S = {15, 22, 13, 27, 12, 10, 20, 25};
		int[] result = new int[S.length];
		
		result = sol.partition2(0, 7, S);
		for(int i = 0 ; i < 8; i++) {
			System.out.print(result[i] + "  ");
			
		}
	}
	
}


class Solution {
	
	public int[] partition1(int low, int high, int[] S) {
		ArrayList<Integer> A = new ArrayList<Integer>();
		ArrayList<Integer> B = new ArrayList<Integer>();
		int pivot = S[low];
		int j = 0;
		int k = 0;
		
		for(int i = low + 1; i <= high; i++) {
			if(S[i] < pivot) {
				A.add(S[i]);
				}
			else {
				B.add(S[i]);
				}
			}
		
		
		for(int i = low; i < A.size(); i++) {
			S[i] = A.get(j);
			j++;
		}
		
		S[j] = pivot;
		
		
		for(int i = j+1; i <= high; i++) {
			S[i] = B.get(k);
			k++;
		}		
		
		return S;		
	}
	
	
	public int[] partition2(int low, int high, int[] S) {
		int[] C = new int[high+1];
		int j = 0;
		int k = 0;
		int pivot = S[low];
		
		for(int i = low + 1; i <= high; i++) {
			if(S[i] < pivot) {
				C[j] = S[i];
				j++;
			}
			else {
				C[high-k] = S[i];
				k++;
			}
		}
		
		C[j] = pivot;
		j = 0;
		
		for(int i = low; i <= high; i++) {
			S[i] = C[j];
			j++;
		}
		
		return S;
	}
}
