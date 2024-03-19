using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDummyGPUInfoList
	/// </summary>
	/// <remarks>
	///    Do thing during Probe()
	///
	/// vtkDummyGPUInfoList implements Probe() by just setting the count of
	/// GPUs to be zero. Useful when an OS specific implementation is not available.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGPUInfo vtkGPUInfoList
	/// </seealso>
	// Token: 0x020005F8 RID: 1528
	public class vtkDummyGPUInfoList : vtkGPUInfoList
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010937 RID: 67895 RVA: 0x0017249F File Offset: 0x0017069F
		static vtkDummyGPUInfoList()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDummyGPUInfoList.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDummyGPUInfoList"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010938 RID: 67896 RVA: 0x001724C7 File Offset: 0x001706C7
		public vtkDummyGPUInfoList(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010939 RID: 67897
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyGPUInfoList_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601093A RID: 67898 RVA: 0x001724D8 File Offset: 0x001706D8
		public new static vtkDummyGPUInfoList New()
		{
			vtkDummyGPUInfoList result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyGPUInfoList.vtkDummyGPUInfoList_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyGPUInfoList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601093B RID: 67899 RVA: 0x0017252C File Offset: 0x0017072C
		public vtkDummyGPUInfoList() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDummyGPUInfoList.vtkDummyGPUInfoList_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601093C RID: 67900 RVA: 0x00172570 File Offset: 0x00170770
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601093D RID: 67901
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDummyGPUInfoList_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601093E RID: 67902 RVA: 0x0017257C File Offset: 0x0017077C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDummyGPUInfoList.vtkDummyGPUInfoList_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601093F RID: 67903
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDummyGPUInfoList_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010940 RID: 67904 RVA: 0x0017259C File Offset: 0x0017079C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDummyGPUInfoList.vtkDummyGPUInfoList_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010941 RID: 67905
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyGPUInfoList_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010942 RID: 67906 RVA: 0x001725B8 File Offset: 0x001707B8
		public override int IsA(string type)
		{
			return vtkDummyGPUInfoList.vtkDummyGPUInfoList_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010943 RID: 67907
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyGPUInfoList_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010944 RID: 67908 RVA: 0x001725D8 File Offset: 0x001707D8
		public new static int IsTypeOf(string type)
		{
			return vtkDummyGPUInfoList.vtkDummyGPUInfoList_IsTypeOf_04(type);
		}

		// Token: 0x06010945 RID: 67909
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyGPUInfoList_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010946 RID: 67910 RVA: 0x001725F4 File Offset: 0x001707F4
		public new vtkDummyGPUInfoList NewInstance()
		{
			vtkDummyGPUInfoList result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyGPUInfoList.vtkDummyGPUInfoList_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyGPUInfoList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010947 RID: 67911
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyGPUInfoList_Probe_07(HandleRef pThis);

		/// <summary>
		/// Build the list of vtkInfoGPU if not done yet.
		/// \post probed: IsProbed()
		/// </summary>
		// Token: 0x06010948 RID: 67912 RVA: 0x0017264E File Offset: 0x0017084E
		public override void Probe()
		{
			vtkDummyGPUInfoList.vtkDummyGPUInfoList_Probe_07(base.GetCppThis());
		}

		// Token: 0x06010949 RID: 67913
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyGPUInfoList_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601094A RID: 67914 RVA: 0x00172660 File Offset: 0x00170860
		public new static vtkDummyGPUInfoList SafeDownCast(vtkObjectBase o)
		{
			vtkDummyGPUInfoList vtkDummyGPUInfoList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyGPUInfoList.vtkDummyGPUInfoList_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDummyGPUInfoList = (vtkDummyGPUInfoList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDummyGPUInfoList.Register(null);
				}
			}
			return vtkDummyGPUInfoList;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001346 RID: 4934
		public new const string MRFullTypeName = "Kitware.VTK.vtkDummyGPUInfoList";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001347 RID: 4935
		public new static readonly string MRClassNameKey = "class vtkDummyGPUInfoList";
	}
}
