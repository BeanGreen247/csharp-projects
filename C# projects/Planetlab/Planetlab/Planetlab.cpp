#include "stdafx.h"
#include "Planetlab.h"
#include <windows.h>
#include <windowsx.h>

LRESULT CALLBACK WindowProc(HWND hWnd,
	UINT message,
	WPARAM wParam,
	LPARAM lParam);

int WINAPI WinMain(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPSTR lpCmdLine,
	int nShowCmd)
{	
		HWND hWnd;
		WNDCLASSEX wc;

		ZeroMemory(&wc, sizeof(WNDCLASSEX));

		wc.cbSize = sizeof(WNDCLASSEX);
		wc.style = CS_HREDRAW | CS_VREDRAW;
		wc.lpfnWndProc = WindowProc;
		wc.hInstance = hInstance;
		wc.hCursor = LoadCursor(NULL, IDC_ARROW);
		wc.hbrBackground = (HBRUSH)COLOR_WINDOW;
		wc.lpszClassName = L"MainWindow";


		//pomocné promìnné
		int windowWidth = 1280;
		int windowHeight = 720;

		RegisterClassEx(&wc);

		hWnd = CreateWindowEx(NULL,
			L"MainWindow",
			L"PlanetLab",  
			WS_OVERLAPPEDWINDOW,   
			300,    // x-position of the window
			300,    // y-position of the window
			windowWidth,    // width of the window
			windowHeight,    // height of the window
			NULL,    
			NULL,    
			hInstance,   
			NULL);

		ShowWindow(hWnd, nShowCmd);

		// enter the main loop:

		MSG msg;

		while (GetMessage(&msg, NULL, 0, 0))
		{
			// translate keystroke messages into the right format
			TranslateMessage(&msg);

			// send the message to the WindowProc function
			DispatchMessage(&msg);
		}

		// return this part of the WM_QUIT message to Windows
		return msg.wParam;
	}


LRESULT CALLBACK WindowProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	// sort through and find what code to run for the message given
	switch (message)
	{
		// this message is read when the window is closed
	case WM_DESTROY:
	{
		// close the application entirely
		PostQuitMessage(0);
		return 0;
	} break;
	}

	// Handle any messages the switch statement didn't
	return DefWindowProc(hWnd, message, wParam, lParam);
}

// http://www.directxtutorial.com/Lesson.aspx?lessonid=9-1-3