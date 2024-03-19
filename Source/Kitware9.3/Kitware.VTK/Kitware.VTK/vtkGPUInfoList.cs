using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGPUInfoList
	/// </summary>
	/// <remarks>
	///    Stores the list of GPUs VRAM information.
	///
	/// vtkGPUInfoList stores a list of vtkGPUInfo. An host can have
	/// several GPUs. It creates and sets the list by probing the host with system
	/// calls. This an abstract class. Concrete classes are OS specific.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGPUInfo vtkDirectXGPUInfoList vtkCoreGraphicsGPUInfoList
	/// </seealso>
	// Token: 0x020005F7 RID: 1527
	public abstract class vtkGPUInfoList : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601091D RID: 67869 RVA: 0x001721A7 File Offset: 0x001703A7
		static vtkGPUInfoList()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGPUInfoList.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUInfoList"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601091E RID: 67870 RVA: 0x001721CF File Offset: 0x001703CF
		public vtkGPUInfoList(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601091F RID: 67871
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUInfoList_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010920 RID: 67872 RVA: 0x001721E0 File Offset: 0x001703E0
		public new static vtkGPUInfoList New()
		{
			vtkGPUInfoList result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfoList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010921 RID: 67873 RVA: 0x00172234 File Offset: 0x00170434
		public vtkGPUInfoList() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGPUInfoList.vtkGPUInfoList_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010922 RID: 67874 RVA: 0x00172278 File Offset: 0x00170478
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010923 RID: 67875
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUInfoList_GetGPUInfo_01(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return information about GPU i.
		/// \pre probed: IsProbed()
		/// \pre valid_index: i&gt;=0 &amp;&amp; i&lt;GetNumberOfGPUs()
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x06010924 RID: 67876 RVA: 0x00172284 File Offset: 0x00170484
		public virtual vtkGPUInfo GetGPUInfo(int i)
		{
			vtkGPUInfo vtkGPUInfo = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_GetGPUInfo_01(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGPUInfo = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGPUInfo.Register(null);
				}
			}
			return vtkGPUInfo;
		}

		// Token: 0x06010925 RID: 67877
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUInfoList_GetNumberOfGPUs_02(HandleRef pThis);

		/// <summary>
		/// Return the number of GPUs.
		/// \pre probed: IsProbed()
		/// </summary>
		// Token: 0x06010926 RID: 67878 RVA: 0x001722F4 File Offset: 0x001704F4
		public virtual int GetNumberOfGPUs()
		{
			return vtkGPUInfoList.vtkGPUInfoList_GetNumberOfGPUs_02(base.GetCppThis());
		}

		// Token: 0x06010927 RID: 67879
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGPUInfoList_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010928 RID: 67880 RVA: 0x00172314 File Offset: 0x00170514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGPUInfoList.vtkGPUInfoList_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010929 RID: 67881
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGPUInfoList_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601092A RID: 67882 RVA: 0x00172334 File Offset: 0x00170534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGPUInfoList.vtkGPUInfoList_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601092B RID: 67883
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUInfoList_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601092C RID: 67884 RVA: 0x00172350 File Offset: 0x00170550
		public override int IsA(string type)
		{
			return vtkGPUInfoList.vtkGPUInfoList_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601092D RID: 67885
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGPUInfoList_IsProbed_06(HandleRef pThis);

		/// <summary>
		/// Tells if the operating system has been probed. Initial value is false.
		/// </summary>
		// Token: 0x0601092E RID: 67886 RVA: 0x00172370 File Offset: 0x00170570
		public virtual bool IsProbed()
		{
			return vtkGPUInfoList.vtkGPUInfoList_IsProbed_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601092F RID: 67887
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUInfoList_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010930 RID: 67888 RVA: 0x00172398 File Offset: 0x00170598
		public new static int IsTypeOf(string type)
		{
			return vtkGPUInfoList.vtkGPUInfoList_IsTypeOf_07(type);
		}

		// Token: 0x06010931 RID: 67889
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUInfoList_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010932 RID: 67890 RVA: 0x001723B4 File Offset: 0x001705B4
		public new vtkGPUInfoList NewInstance()
		{
			vtkGPUInfoList result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfoList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010933 RID: 67891
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUInfoList_Probe_10(HandleRef pThis);

		/// <summary>
		/// Build the list of vtkInfoGPU if not done yet.
		/// Default implementation created an empty list. Useful if there is no
		/// implementation available for a given architecture yet.
		/// \post probed: IsProbed()
		/// </summary>
		// Token: 0x06010934 RID: 67892 RVA: 0x0017240E File Offset: 0x0017060E
		public virtual void Probe()
		{
			vtkGPUInfoList.vtkGPUInfoList_Probe_10(base.GetCppThis());
		}

		// Token: 0x06010935 RID: 67893
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUInfoList_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010936 RID: 67894 RVA: 0x00172420 File Offset: 0x00170620
		public new static vtkGPUInfoList SafeDownCast(vtkObjectBase o)
		{
			vtkGPUInfoList vtkGPUInfoList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGPUInfoList = (vtkGPUInfoList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGPUInfoList.Register(null);
				}
			}
			return vtkGPUInfoList;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001344 RID: 4932
		public new const string MRFullTypeName = "Kitware.VTK.vtkGPUInfoList";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001345 RID: 4933
		public new static readonly string MRClassNameKey = "class vtkGPUInfoList";
	}
}
