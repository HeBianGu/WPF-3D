using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCirclePackToPolyData
	/// </summary>
	/// <remarks>
	///    converts a tree to a polygonal data
	/// representing a circle packing of the hierarchy.
	///
	///
	/// This algorithm requires that the vtkCirclePackLayout filter has already
	/// been applied to the data in order to create the triple array
	/// (Xcenter, Ycenter, Radius) of circle bounds or each vertex of the tree.
	/// </remarks>
	// Token: 0x02000285 RID: 645
	public class vtkCirclePackToPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060074A4 RID: 29860 RVA: 0x000A8B37 File Offset: 0x000A6D37
		static vtkCirclePackToPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCirclePackToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCirclePackToPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060074A5 RID: 29861 RVA: 0x000A8B5F File Offset: 0x000A6D5F
		public vtkCirclePackToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060074A6 RID: 29862
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074A7 RID: 29863 RVA: 0x000A8B70 File Offset: 0x000A6D70
		public new static vtkCirclePackToPolyData New()
		{
			vtkCirclePackToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackToPolyData.vtkCirclePackToPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCirclePackToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074A8 RID: 29864 RVA: 0x000A8BC4 File Offset: 0x000A6DC4
		public vtkCirclePackToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCirclePackToPolyData.vtkCirclePackToPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060074A9 RID: 29865 RVA: 0x000A8C08 File Offset: 0x000A6E08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060074AA RID: 29866
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackToPolyData_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Define the number of sides used in output circles.
		/// Default is 100.
		/// </summary>
		// Token: 0x060074AB RID: 29867 RVA: 0x000A8C14 File Offset: 0x000A6E14
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkCirclePackToPolyData.vtkCirclePackToPolyData_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x060074AC RID: 29868
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackToPolyData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074AD RID: 29869 RVA: 0x000A8C4C File Offset: 0x000A6E4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCirclePackToPolyData.vtkCirclePackToPolyData_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060074AE RID: 29870
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackToPolyData_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074AF RID: 29871 RVA: 0x000A8C6C File Offset: 0x000A6E6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCirclePackToPolyData.vtkCirclePackToPolyData_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060074B0 RID: 29872
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCirclePackToPolyData_GetResolution_04(HandleRef pThis);

		/// <summary>
		/// Define the number of sides used in output circles.
		/// Default is 100.
		/// </summary>
		// Token: 0x060074B1 RID: 29873 RVA: 0x000A8C88 File Offset: 0x000A6E88
		public virtual uint GetResolution()
		{
			return vtkCirclePackToPolyData.vtkCirclePackToPolyData_GetResolution_04(base.GetCppThis());
		}

		// Token: 0x060074B2 RID: 29874
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackToPolyData_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074B3 RID: 29875 RVA: 0x000A8CA8 File Offset: 0x000A6EA8
		public override int IsA(string type)
		{
			return vtkCirclePackToPolyData.vtkCirclePackToPolyData_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060074B4 RID: 29876
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackToPolyData_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074B5 RID: 29877 RVA: 0x000A8CC8 File Offset: 0x000A6EC8
		public new static int IsTypeOf(string type)
		{
			return vtkCirclePackToPolyData.vtkCirclePackToPolyData_IsTypeOf_06(type);
		}

		// Token: 0x060074B6 RID: 29878
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackToPolyData_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074B7 RID: 29879 RVA: 0x000A8CE4 File Offset: 0x000A6EE4
		public new vtkCirclePackToPolyData NewInstance()
		{
			vtkCirclePackToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackToPolyData.vtkCirclePackToPolyData_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCirclePackToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060074B8 RID: 29880
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackToPolyData_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074B9 RID: 29881 RVA: 0x000A8D40 File Offset: 0x000A6F40
		public new static vtkCirclePackToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkCirclePackToPolyData vtkCirclePackToPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackToPolyData.vtkCirclePackToPolyData_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCirclePackToPolyData = (vtkCirclePackToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCirclePackToPolyData.Register(null);
				}
			}
			return vtkCirclePackToPolyData;
		}

		// Token: 0x060074BA RID: 29882
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackToPolyData_SetCirclesArrayName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The field containing triples of the form (Xcenter, Ycenter, Radius).
		///
		/// This field may be added to the tree using vtkCirclePackLayout.
		/// This array must be set.
		/// </summary>
		// Token: 0x060074BB RID: 29883 RVA: 0x000A8DBF File Offset: 0x000A6FBF
		public virtual void SetCirclesArrayName(string name)
		{
			vtkCirclePackToPolyData.vtkCirclePackToPolyData_SetCirclesArrayName_10(base.GetCppThis(), name);
		}

		// Token: 0x060074BC RID: 29884
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackToPolyData_SetResolution_11(HandleRef pThis, uint _arg);

		/// <summary>
		/// Define the number of sides used in output circles.
		/// Default is 100.
		/// </summary>
		// Token: 0x060074BD RID: 29885 RVA: 0x000A8DCF File Offset: 0x000A6FCF
		public virtual void SetResolution(uint _arg)
		{
			vtkCirclePackToPolyData.vtkCirclePackToPolyData_SetResolution_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A18 RID: 2584
		public new const string MRFullTypeName = "Kitware.VTK.vtkCirclePackToPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A19 RID: 2585
		public new static readonly string MRClassNameKey = "class vtkCirclePackToPolyData";
	}
}
