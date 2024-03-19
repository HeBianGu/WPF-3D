using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkDebugLeaks
	/// </summary>
	/// <remarks>
	///  identify memory leaks at program termination
	/// vtkDebugLeaks is used to report memory leaks at the exit of the program. It
	/// uses vtkObjectBase::InitializeObjectBase() (called via vtkObjectFactory
	/// macros) to intercept the construction of all VTK objects. It uses the
	/// UnRegisterInternal method of vtkObjectBase to intercept the destruction of
	/// all objects.
	///
	/// If not using the vtkObjectFactory macros to implement New(), be sure to call
	/// vtkObjectBase::InitializeObjectBase() explicitly on the constructed
	/// instance. The rule of thumb is that wherever "new [some vtkObjectBase
	/// subclass]" is called, vtkObjectBase::InitializeObjectBase() must be called
	/// as well.
	///
	/// There are exceptions to this:
	///
	/// - vtkCommand subclasses traditionally do not fully participate in
	/// vtkDebugLeaks registration, likely because they typically do not use
	/// vtkTypeMacro to configure GetClassName. InitializeObjectBase should not be
	/// called on vtkCommand subclasses, and all such classes will be automatically
	/// registered with vtkDebugLeaks as "vtkCommand or subclass".
	///
	/// - vtkInformationKey subclasses are not reference counted. They are allocated
	/// statically and registered automatically with a singleton "manager" instance.
	/// The manager ensures that all keys are cleaned up before exiting, and
	/// registration/deregistration with vtkDebugLeaks is bypassed.
	///
	/// A table of object name to number of instances is kept. At the exit of the
	/// program if there are still VTK objects around it will print them out. To
	/// enable this class add the flag -DVTK_DEBUG_LEAKS to the compile line, and
	/// rebuild vtkObject and vtkObjectFactory.
	/// </remarks>
	// Token: 0x02000B4F RID: 2895
	public class vtkDebugLeaks : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E3EA RID: 123882 RVA: 0x002AC984 File Offset: 0x002AAB84
		static vtkDebugLeaks()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDebugLeaks.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDebugLeaks"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E3EB RID: 123883 RVA: 0x002AC9AC File Offset: 0x002AABAC
		public vtkDebugLeaks(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E3EC RID: 123884
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDebugLeaks_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3ED RID: 123885 RVA: 0x002AC9BC File Offset: 0x002AABBC
		public new static vtkDebugLeaks New()
		{
			vtkDebugLeaks result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDebugLeaks.vtkDebugLeaks_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3EE RID: 123886 RVA: 0x002ACA10 File Offset: 0x002AAC10
		public vtkDebugLeaks() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDebugLeaks.vtkDebugLeaks_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E3EF RID: 123887 RVA: 0x002ACA54 File Offset: 0x002AAC54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E3F0 RID: 123888
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDebugLeaks_ConstructClass_01(HandleRef arg0);

		/// <summary>
		/// Call this when creating a class.
		/// </summary>
		// Token: 0x0601E3F1 RID: 123889 RVA: 0x002ACA60 File Offset: 0x002AAC60
		public static void ConstructClass(vtkObjectBase arg0)
		{
			vtkDebugLeaks.vtkDebugLeaks_ConstructClass_01((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601E3F2 RID: 123890
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDebugLeaks_ConstructClass_02([MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		/// Call this when creating a vtkCommand or subclasses.
		/// </summary>
		// Token: 0x0601E3F3 RID: 123891 RVA: 0x002ACA89 File Offset: 0x002AAC89
		public static void ConstructClass(string className)
		{
			vtkDebugLeaks.vtkDebugLeaks_ConstructClass_02(className);
		}

		// Token: 0x0601E3F4 RID: 123892
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDebugLeaks_DestructClass_03(HandleRef arg0);

		/// <summary>
		/// Call this when deleting a class.
		/// </summary>
		// Token: 0x0601E3F5 RID: 123893 RVA: 0x002ACA94 File Offset: 0x002AAC94
		public static void DestructClass(vtkObjectBase arg0)
		{
			vtkDebugLeaks.vtkDebugLeaks_DestructClass_03((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601E3F6 RID: 123894
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDebugLeaks_DestructClass_04([MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		/// Call this when deleting vtkCommand or a subclass.
		/// </summary>
		// Token: 0x0601E3F7 RID: 123895 RVA: 0x002ACABD File Offset: 0x002AACBD
		public static void DestructClass(string className)
		{
			vtkDebugLeaks.vtkDebugLeaks_DestructClass_04(className);
		}

		// Token: 0x0601E3F8 RID: 123896
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDebugLeaks_GetExitError_05();

		/// <summary>
		/// Get/Set flag for exiting with an error when leaks are present.
		/// Default is on when VTK_DEBUG_LEAKS is on and off otherwise.
		/// </summary>
		// Token: 0x0601E3F9 RID: 123897 RVA: 0x002ACAC8 File Offset: 0x002AACC8
		public static int GetExitError()
		{
			return vtkDebugLeaks.vtkDebugLeaks_GetExitError_05();
		}

		// Token: 0x0601E3FA RID: 123898
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDebugLeaks_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3FB RID: 123899 RVA: 0x002ACAE4 File Offset: 0x002AACE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDebugLeaks.vtkDebugLeaks_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E3FC RID: 123900
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDebugLeaks_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3FD RID: 123901 RVA: 0x002ACB04 File Offset: 0x002AAD04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDebugLeaks.vtkDebugLeaks_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601E3FE RID: 123902
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDebugLeaks_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3FF RID: 123903 RVA: 0x002ACB20 File Offset: 0x002AAD20
		public override int IsA(string type)
		{
			return vtkDebugLeaks.vtkDebugLeaks_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601E400 RID: 123904
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDebugLeaks_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E401 RID: 123905 RVA: 0x002ACB40 File Offset: 0x002AAD40
		public new static int IsTypeOf(string type)
		{
			return vtkDebugLeaks.vtkDebugLeaks_IsTypeOf_09(type);
		}

		// Token: 0x0601E402 RID: 123906
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDebugLeaks_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E403 RID: 123907 RVA: 0x002ACB5C File Offset: 0x002AAD5C
		public new vtkDebugLeaks NewInstance()
		{
			vtkDebugLeaks result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDebugLeaks.vtkDebugLeaks_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E404 RID: 123908
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDebugLeaks_PrintCurrentLeaks_12();

		/// <summary>
		/// Print all the values in the table.  Returns non-zero if there
		/// were leaks.
		/// </summary>
		// Token: 0x0601E405 RID: 123909 RVA: 0x002ACBB8 File Offset: 0x002AADB8
		public static int PrintCurrentLeaks()
		{
			return vtkDebugLeaks.vtkDebugLeaks_PrintCurrentLeaks_12();
		}

		// Token: 0x0601E406 RID: 123910
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDebugLeaks_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E407 RID: 123911 RVA: 0x002ACBD4 File Offset: 0x002AADD4
		public new static vtkDebugLeaks SafeDownCast(vtkObjectBase o)
		{
			vtkDebugLeaks vtkDebugLeaks = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDebugLeaks.vtkDebugLeaks_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDebugLeaks = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDebugLeaks.Register(null);
				}
			}
			return vtkDebugLeaks;
		}

		// Token: 0x0601E408 RID: 123912
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDebugLeaks_SetExitError_14(int arg0);

		/// <summary>
		/// Get/Set flag for exiting with an error when leaks are present.
		/// Default is on when VTK_DEBUG_LEAKS is on and off otherwise.
		/// </summary>
		// Token: 0x0601E409 RID: 123913 RVA: 0x002ACC53 File Offset: 0x002AAE53
		public static void SetExitError(int arg0)
		{
			vtkDebugLeaks.vtkDebugLeaks_SetExitError_14(arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400207A RID: 8314
		public new const string MRFullTypeName = "Kitware.VTK.vtkDebugLeaks";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400207B RID: 8315
		public new static readonly string MRClassNameKey = "class vtkDebugLeaks";
	}
}
