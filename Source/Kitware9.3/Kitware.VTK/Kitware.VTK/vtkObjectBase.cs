using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkObjectBase
	/// </summary>
	/// <remarks>
	///    abstract base class for most VTK objects
	///
	/// vtkObjectBase is the base class for all reference counted classes
	/// in the VTK. These classes include vtkCommand classes, vtkInformationKey
	/// classes, and vtkObject classes.
	///
	/// vtkObjectBase performs reference counting: objects that are
	/// reference counted exist as long as another object uses them. Once
	/// the last reference to a reference counted object is removed, the
	/// object will spontaneously destruct.
	///
	/// Constructor and destructor of the subclasses of vtkObjectBase
	/// should be protected, so that only New() and UnRegister() actually
	/// call them. Debug leaks can be used to see if there are any objects
	/// left with nonzero reference count.
	///
	/// @warning
	/// Note: Objects of subclasses of vtkObjectBase should always be
	/// created with the New() method and deleted with the Delete()
	/// method. They cannot be allocated off the stack (i.e., automatic
	/// objects) because the constructor is a protected method.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkObject vtkCommand vtkInformationKey
	/// </seealso>
	// Token: 0x02000003 RID: 3
	public class vtkObjectBase : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000002 RID: 2 RVA: 0x000020E9 File Offset: 0x000002E9
		static vtkObjectBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000003 RID: 3 RVA: 0x00002111 File Offset: 0x00000311
		public vtkObjectBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000004 RID: 4
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectBase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an object with Debug turned off, modified time initialized
		/// to zero, and reference counting on.
		/// </summary>
		// Token: 0x06000005 RID: 5 RVA: 0x00002120 File Offset: 0x00000320
		public static vtkObjectBase New()
		{
			vtkObjectBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectBase.vtkObjectBase_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an object with Debug turned off, modified time initialized
		/// to zero, and reference counting on.
		/// </summary>
		// Token: 0x06000006 RID: 6 RVA: 0x00002174 File Offset: 0x00000374
		public vtkObjectBase() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkObjectBase.vtkObjectBase_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		// Token: 0x06000007 RID: 7
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectBase_Register_16(HandleRef pThis, HandleRef o);

		/// <summary>
		/// Increase the reference count (mark as used by another object).
		/// </summary>
		// Token: 0x06000008 RID: 8 RVA: 0x000021B8 File Offset: 0x000003B8
		public virtual void Register(vtkObjectBase o)
		{
			vtkObjectBase.vtkObjectBase_Register_16(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		// Token: 0x06000009 RID: 9
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectBase_UnRegister_19(HandleRef pThis, HandleRef o);

		/// <summary>
		/// Decrease the reference count (release by another object). This
		/// has the same effect as invoking Delete() (i.e., it reduces the
		/// reference count by 1).
		/// </summary>
		// Token: 0x0600000A RID: 10 RVA: 0x000021E8 File Offset: 0x000003E8
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkObjectBase.vtkObjectBase_UnRegister_19(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600000B RID: 11
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectBase_FastDelete_02(HandleRef pThis);

		/// <summary>
		/// Delete a reference to this object.  This version will not invoke
		/// garbage collection and can potentially leak the object if it is
		/// part of a reference loop.  Use this method only when it is known
		/// that the object has another reference and would not be collected
		/// if a full garbage collection check were done.
		/// </summary>
		// Token: 0x0600000C RID: 12 RVA: 0x00002244 File Offset: 0x00000444
		public virtual void FastDelete()
		{
			vtkObjectBase.vtkObjectBase_FastDelete_02(base.GetCppThis());
		}

		// Token: 0x0600000D RID: 13
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectBase_GetClassName_03(HandleRef pThis);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x0600000E RID: 14 RVA: 0x00002254 File Offset: 0x00000454
		public string GetClassName()
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectBase.vtkObjectBase_GetClassName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600000F RID: 15
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectBase_GetClassNameA_04(HandleRef pThis);

		/// <summary>
		/// The object description printed in messages and PrintSelf
		/// output. To be used only for reporting purposes.
		/// </summary>
		// Token: 0x06000010 RID: 16 RVA: 0x00002290 File Offset: 0x00000490
		public string GetClassNameA()
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectBase.vtkObjectBase_GetClassNameA_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000011 RID: 17
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectBase_GetClassNameW_05(HandleRef pThis);

		/// <summary>
		/// The object description printed in messages and PrintSelf
		/// output. To be used only for reporting purposes.
		/// </summary>
		// Token: 0x06000012 RID: 18 RVA: 0x000022CC File Offset: 0x000004CC
		public string GetClassNameW()
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectBase.vtkObjectBase_GetClassNameW_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000013 RID: 19
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkObjectBase_GetIsInMemkind_06(HandleRef pThis);

		/// <summary>
		/// A local state flag that remembers whether this object lives in
		/// the normal or extended memory space.
		/// </summary>
		// Token: 0x06000014 RID: 20 RVA: 0x00002308 File Offset: 0x00000508
		public bool GetIsInMemkind()
		{
			return vtkObjectBase.vtkObjectBase_GetIsInMemkind_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06000015 RID: 21
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObjectBase_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Given the name of a base class of this class type, return the distance
		/// of inheritance between this class type and the named class (how many
		/// generations of inheritance are there between this class and the named
		/// class). If the named class is not in this class's inheritance tree, return
		/// a negative value. Valid responses will always be nonnegative. This method
		/// works in combination with vtkTypeMacro found in vtkSetGet.h.
		/// </summary>
		// Token: 0x06000016 RID: 22 RVA: 0x00002330 File Offset: 0x00000530
		public virtual long GetNumberOfGenerationsFromBase(string name)
		{
			return vtkObjectBase.vtkObjectBase_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), name);
		}

		// Token: 0x06000017 RID: 23
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObjectBase_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Given a the name of a base class of this class type, return the distance
		/// of inheritance between this class type and the named class (how many
		/// generations of inheritance are there between this class and the named
		/// class). If the named class is not in this class's inheritance tree, return
		/// a negative value. Valid responses will always be nonnegative. This method
		/// works in combination with vtkTypeMacro found in vtkSetGet.h.
		/// </summary>
		// Token: 0x06000018 RID: 24 RVA: 0x00002350 File Offset: 0x00000550
		public static long GetNumberOfGenerationsFromBaseType(string name)
		{
			return vtkObjectBase.vtkObjectBase_GetNumberOfGenerationsFromBaseType_08(name);
		}

		// Token: 0x06000019 RID: 25
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkObjectBase_GetObjectDescription_09(HandleRef pThis);

		/// <summary>
		/// The object description printed in messages and PrintSelf
		/// output. To be used only for reporting purposes.
		/// </summary>
		// Token: 0x0600001A RID: 26 RVA: 0x0000236C File Offset: 0x0000056C
		public virtual string GetObjectDescription()
		{
			return vtkObjectBase.vtkObjectBase_GetObjectDescription_09(base.GetCppThis());
		}

		// Token: 0x0600001B RID: 27
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectBase_GetReferenceCount_10(HandleRef pThis);

		/// <summary>
		/// Return the current reference count of this object.
		/// </summary>
		// Token: 0x0600001C RID: 28 RVA: 0x0000238C File Offset: 0x0000058C
		public int GetReferenceCount()
		{
			return vtkObjectBase.vtkObjectBase_GetReferenceCount_10(base.GetCppThis());
		}

		// Token: 0x0600001D RID: 29
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkObjectBase_GetUsingMemkind_11();

		/// <summary>
		/// A global state flag that controls whether vtkObjects are
		/// constructed in the usual way (the default) or within the extended
		/// memory space.
		/// </summary>
		// Token: 0x0600001E RID: 30 RVA: 0x000023AC File Offset: 0x000005AC
		public static bool GetUsingMemkind()
		{
			return vtkObjectBase.vtkObjectBase_GetUsingMemkind_11() != 0;
		}

		// Token: 0x0600001F RID: 31
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectBase_InitializeObjectBase_12(HandleRef pThis);

		/// <summary>
		/// Create an object with Debug turned off, modified time initialized
		/// to zero, and reference counting on.
		/// </summary>
		// Token: 0x06000020 RID: 32 RVA: 0x000023CC File Offset: 0x000005CC
		public void InitializeObjectBase()
		{
			vtkObjectBase.vtkObjectBase_InitializeObjectBase_12(base.GetCppThis());
		}

		// Token: 0x06000021 RID: 33
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectBase_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return 1 if this class is the same type of (or a subclass of)
		/// the named class. Returns 0 otherwise. This method works in
		/// combination with vtkTypeMacro found in vtkSetGet.h.
		/// </summary>
		// Token: 0x06000022 RID: 34 RVA: 0x000023DC File Offset: 0x000005DC
		public virtual int IsA(string name)
		{
			return vtkObjectBase.vtkObjectBase_IsA_13(base.GetCppThis(), name);
		}

		// Token: 0x06000023 RID: 35
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectBase_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return 1 if this class type is the same type of (or a subclass of)
		/// the named class. Returns 0 otherwise. This method works in
		/// combination with vtkTypeMacro found in vtkSetGet.h.
		/// </summary>
		// Token: 0x06000024 RID: 36 RVA: 0x000023FC File Offset: 0x000005FC
		public static int IsTypeOf(string name)
		{
			return vtkObjectBase.vtkObjectBase_IsTypeOf_14(name);
		}

		// Token: 0x06000025 RID: 37
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectBase_SetMemkindDirectory_17([MarshalAs(UnmanagedType.LPUTF8Str)] string directoryname);

		/// <summary>
		/// The name of a directory, ideally mounted -o dax, to memory map an
		/// extended memory space within.
		/// This must be called before any objects are constructed in the extended space.
		/// It can not be changed once setup.
		/// </summary>
		// Token: 0x06000026 RID: 38 RVA: 0x00002416 File Offset: 0x00000616
		public static void SetMemkindDirectory(string directoryname)
		{
			vtkObjectBase.vtkObjectBase_SetMemkindDirectory_17(directoryname);
		}

		// Token: 0x06000027 RID: 39
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectBase_SetReferenceCount_18(HandleRef pThis, int arg0);

		/// <summary>
		/// Sets the reference count. (This is very dangerous, use with care.)
		/// </summary>
		// Token: 0x06000028 RID: 40 RVA: 0x00002420 File Offset: 0x00000620
		public void SetReferenceCount(int arg0)
		{
			vtkObjectBase.vtkObjectBase_SetReferenceCount_18(base.GetCppThis(), arg0);
		}

		// Token: 0x06000029 RID: 41
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkObjectBase_UsesGarbageCollector_20(HandleRef pThis);

		/// <summary>
		/// Indicate whether the class uses `vtkGarbageCollector` or not.
		///
		/// Most classes will not need to do this, but if the class participates in a
		/// strongly-connected reference count cycle, participation can resolve these
		/// cycles.
		///
		/// If overriding this method to return true, the `ReportReferences` method
		/// should be overridden to report references that may be in cycles.
		/// </summary>
		// Token: 0x0600002A RID: 42 RVA: 0x00002430 File Offset: 0x00000630
		public virtual bool UsesGarbageCollector()
		{
			return vtkObjectBase.vtkObjectBase_UsesGarbageCollector_20(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400007A RID: 122
		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400007B RID: 123
		public new static readonly string MRClassNameKey = "class vtkObjectBase";
	}
}
