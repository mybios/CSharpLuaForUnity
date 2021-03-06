﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class MonoManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MonoManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Create", Create);
		L.RegFunction("Update", Update);
		L.RegFunction("LateUpdate", LateUpdate);
		L.RegFunction("FixedUpdate", FixedUpdate);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onUpdate", get_onUpdate, set_onUpdate);
		L.RegVar("onLateUpdate", get_onLateUpdate, set_onLateUpdate);
		L.RegVar("onFixedUpdate", get_onFixedUpdate, set_onFixedUpdate);
		L.RegVar("onApplicationQuit", get_onApplicationQuit, set_onApplicationQuit);
		L.RegVar("Instance", get_Instance, null);
		L.RegFunction("getInstance", get_Instance);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			MonoManager.Create();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (MonoManager)ToLua.CheckObject<MonoManager>(L, 1);
			obj.Update();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LateUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (MonoManager)ToLua.CheckObject<MonoManager>(L, 1);
			obj.LateUpdate();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FixedUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (MonoManager)ToLua.CheckObject<MonoManager>(L, 1);
			obj.FixedUpdate();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent ret = obj.onUpdate;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onLateUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent ret = obj.onLateUpdate;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onLateUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onFixedUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent ret = obj.onFixedUpdate;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onFixedUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onApplicationQuit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent ret = obj.onApplicationQuit;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onApplicationQuit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, MonoManager.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent arg0 = (UnityEngine.Events.UnityEvent)ToLua.CheckObject<UnityEngine.Events.UnityEvent>(L, 2);
			obj.onUpdate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onLateUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent arg0 = (UnityEngine.Events.UnityEvent)ToLua.CheckObject<UnityEngine.Events.UnityEvent>(L, 2);
			obj.onLateUpdate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onLateUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onFixedUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent arg0 = (UnityEngine.Events.UnityEvent)ToLua.CheckObject<UnityEngine.Events.UnityEvent>(L, 2);
			obj.onFixedUpdate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onFixedUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onApplicationQuit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MonoManager obj = (MonoManager)o;
			UnityEngine.Events.UnityEvent arg0 = (UnityEngine.Events.UnityEvent)ToLua.CheckObject<UnityEngine.Events.UnityEvent>(L, 2);
			obj.onApplicationQuit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onApplicationQuit on a nil value");
		}
	}
}

