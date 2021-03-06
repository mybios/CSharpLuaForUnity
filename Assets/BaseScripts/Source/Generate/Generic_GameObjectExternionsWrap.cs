﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class Generic_GameObjectExternionsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("GameObjectExternions");
		L.RegFunction("AddComponent0T", AddComponent0T);
		L.RegFunction("GetComponent0T", GetComponent0T);
		L.RegFunction("GetComponentInChildren0T", GetComponentInChildren0T);
		L.RegFunction("GetComponentInChildren1T", GetComponentInChildren1T);
		L.RegFunction("GetComponentsInChildren0T", GetComponentsInChildren0T);
		L.RegFunction("GetComponentsInChildren2T", GetComponentsInChildren2T);
		L.RegFunction("GetComponentInParent0T", GetComponentInParent0T);
		L.RegFunction("GetComponentsInParent0T", GetComponentsInParent0T);
		L.RegFunction("GetComponentsInParent1T", GetComponentsInParent1T);
		L.RegFunction("GetComponents0T", GetComponents0T);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddComponent0T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			var o = Generic.GameObjectExternions.AddComponent0T(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponent0T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			var o = Generic.GameObjectExternions.GetComponent0T(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInChildren0T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			var o = Generic.GameObjectExternions.GetComponentInChildren0T(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInChildren1T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			System.Type arg2 = ToLua.CheckMonoType(L, 3);
			var o = Generic.GameObjectExternions.GetComponentInChildren1T(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInChildren0T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			var o = Generic.GameObjectExternions.GetComponentsInChildren0T(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInChildren2T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			System.Type arg2 = ToLua.CheckMonoType(L, 3);
			var o = Generic.GameObjectExternions.GetComponentsInChildren2T(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInParent0T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			var o = Generic.GameObjectExternions.GetComponentInParent0T(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInParent0T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			var o = Generic.GameObjectExternions.GetComponentsInParent0T(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInParent1T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			System.Type arg2 = ToLua.CheckMonoType(L, 3);
			var o = Generic.GameObjectExternions.GetComponentsInParent1T(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponents0T(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			var o = Generic.GameObjectExternions.GetComponents0T(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

