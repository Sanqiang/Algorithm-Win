package Question9_2;

import java.util.ArrayList;
import java.util.Hashtable;
import java.awt.*;

import CtCILibrary.AssortedMethods;

public class QuestionDP {
	public static int[][] maze = new int[10][10];
	
	public static boolean isFree(int x, int y) {
		if (maze[x][y] == 0) {
			return false;
		} else {
			return true;
		}
	}

	public static boolean getPath(int x, int y, ArrayList<Point> path, Hashtable<Point, Boolean> cache) {
		Point p = new Point(x, y);
		if (cache.containsKey(p)) { // Already visited this cell
			return cache.get(p);
		}
		path.add(p);
		if (x == 0 && y == 0) {
			return true; // found a path
		}
		boolean success = false;
		if (x >= 1 && isFree(x - 1, y)) { // Try right
			success = getPath(x - 1, y, path, cache); // Free!  Go right
		}
		if (!success && y >= 1 && isFree(x, y - 1)) { // Try down
			success = getPath(x, y - 1, path, cache); // Free!  Go down
		}
		if (!success) {
			path.remove(p); // Wrong way! Better stop going this way
		}
		cache.put(p, success); // Cache result
		return success;
	}
	
	public static void main(String[] args) {
		maze = AssortedMethods.randomMatrix(10, 10, 0, 4);
		AssortedMethods.printMatrix(maze);
		ArrayList<Point> path = new ArrayList<Point>();
		Hashtable<Point, Boolean> cache = new Hashtable<Point, Boolean>();
		boolean success = getPath(9, 9, path, cache);
		if (success) {
			String s = AssortedMethods.listOfPointsToString(path);
			System.out.println(s);
		} else {
			System.out.println("No path found.");
		}
	}

}
