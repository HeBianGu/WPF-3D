using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCriticalSection
	/// </summary>
	/// <remarks>
	///    Critical section locking class
	///
	/// vtkCriticalSection allows the locking of variables which are accessed
	/// through different threads.  This header file also defines
	/// vtkSimpleCriticalSection which is not a subclass of vtkObject.
	/// The API is identical to that of vtkMutexLock, and the behavior is
	/// identical as well, except on Windows 9x/NT platforms. The only difference
	/// on these platforms is that vtkMutexLock is more flexible, in that
	/// it works across processes as well as across threads, but also costs
	/// more, in that it evokes a 600-cycle x86 ring transition. The
	/// vtkCriticalSection provides a higher-performance equivalent (on
	/// Windows) but won't work across processes. Since it is unclear how,
	/// in vtk, an object at the vtk level can be shared across processes
	/// in the first place, one should use vtkCriticalSection unless one has
	/// a very good reason to use vtkMutexLock. If higher-performance equivalents
	/// for non-Windows platforms (Irix, SunOS, etc) are discovered, they
	/// should replace the implementations in this class
	/// </remarks>
	// Token: 0x02000B8C RID: 2956
	public class vtkCriticalSection : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ED47 RID: 126279 RVA: 0x002BBA57 File Offset: 0x002B9C57
		static vtkCriticalSection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCriticalSection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCriticalSection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED48 RID: 126280 RVA: 0x002BBA7F File Offset: 0x002B9C7F
		public vtkCriticalSection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ED49 RID: 126281
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCriticalSection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED4A RID: 126282 RVA: 0x002BBA90 File Offset: 0x002B9C90
		public new static vtkCriticalSection New()
		{
			vtkCriticalSection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCriticalSection.vtkCriticalSection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCriticalSection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED4B RID: 126283 RVA: 0x002BBAE4 File Offset: 0x002B9CE4
		public vtkCriticalSection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCriticalSection.vtkCriticalSection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED4C RID: 126284 RVA: 0x002BBB28 File Offset: 0x002B9D28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ED4D RID: 126285
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCriticalSection_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED4E RID: 126286 RVA: 0x002BBB34 File Offset: 0x002B9D34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCriticalSection.vtkCriticalSection_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601ED4F RID: 126287
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCriticalSection_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED50 RID: 126288 RVA: 0x002BBB54 File Offset: 0x002B9D54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCriticalSection.vtkCriticalSection_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601ED51 RID: 126289
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCriticalSection_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED52 RID: 126290 RVA: 0x002BBB70 File Offset: 0x002B9D70
		public override int IsA(string type)
		{
			return vtkCriticalSection.vtkCriticalSection_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601ED53 RID: 126291
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCriticalSection_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED54 RID: 126292 RVA: 0x002BBB90 File Offset: 0x002B9D90
		public new static int IsTypeOf(string type)
		{
			return vtkCriticalSection.vtkCriticalSection_IsTypeOf_04(type);
		}

		// Token: 0x0601ED55 RID: 126293
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCriticalSection_Lock_05(HandleRef pThis);

		/// <summary>
		/// Lock the vtkCriticalSection
		/// </summary>
		// Token: 0x0601ED56 RID: 126294 RVA: 0x002BBBAA File Offset: 0x002B9DAA
		public void Lock()
		{
			vtkCriticalSection.vtkCriticalSection_Lock_05(base.GetCppThis());
		}

		// Token: 0x0601ED57 RID: 126295
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCriticalSection_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED58 RID: 126296 RVA: 0x002BBBBC File Offset: 0x002B9DBC
		public new vtkCriticalSection NewInstance()
		{
			vtkCriticalSection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCriticalSection.vtkCriticalSection_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCriticalSection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ED59 RID: 126297
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCriticalSection_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED5A RID: 126298 RVA: 0x002BBC18 File Offset: 0x002B9E18
		public new static vtkCriticalSection SafeDownCast(vtkObjectBase o)
		{
			vtkCriticalSection vtkCriticalSection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCriticalSection.vtkCriticalSection_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCriticalSection = (vtkCriticalSection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCriticalSection.Register(null);
				}
			}
			return vtkCriticalSection;
		}

		// Token: 0x0601ED5B RID: 126299
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCriticalSection_Unlock_09(HandleRef pThis);

		/// <summary>
		/// Unlock the vtkCriticalSection
		/// </summary>
		// Token: 0x0601ED5C RID: 126300 RVA: 0x002BBC97 File Offset: 0x002B9E97
		public void Unlock()
		{
			vtkCriticalSection.vtkCriticalSection_Unlock_09(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002108 RID: 8456
		public new const string MRFullTypeName = "Kitware.VTK.vtkCriticalSection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002109 RID: 8457
		public new static readonly string MRClassNameKey = "class vtkCriticalSection";
	}
}
