using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeRingToPolyData
	/// </summary>
	/// <remarks>
	///    converts a tree to a polygonal data
	/// representing radial space filling tree.
	///
	///
	/// This algorithm requires that the vtkTreeRingLayout filter has already
	/// been applied to the data in order to create the quadruple array
	/// (start angle, end angle, inner radius, outer radius) of bounds
	/// for each vertex of the tree.
	/// </remarks>
	// Token: 0x020002A5 RID: 677
	public class vtkTreeRingToPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060079F6 RID: 31222 RVA: 0x000AFC6B File Offset: 0x000ADE6B
		static vtkTreeRingToPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeRingToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeRingToPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060079F7 RID: 31223 RVA: 0x000AFC93 File Offset: 0x000ADE93
		public vtkTreeRingToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060079F8 RID: 31224
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeRingToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079F9 RID: 31225 RVA: 0x000AFCA4 File Offset: 0x000ADEA4
		public new static vtkTreeRingToPolyData New()
		{
			vtkTreeRingToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeRingToPolyData.vtkTreeRingToPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079FA RID: 31226 RVA: 0x000AFCF8 File Offset: 0x000ADEF8
		public vtkTreeRingToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeRingToPolyData.vtkTreeRingToPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060079FB RID: 31227 RVA: 0x000AFD3C File Offset: 0x000ADF3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060079FC RID: 31228
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeRingToPolyData_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Define a shrink percentage for each of the sectors.
		/// </summary>
		// Token: 0x060079FD RID: 31229 RVA: 0x000AFD48 File Offset: 0x000ADF48
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x060079FE RID: 31230
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeRingToPolyData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079FF RID: 31231 RVA: 0x000AFD80 File Offset: 0x000ADF80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06007A00 RID: 31232
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeRingToPolyData_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A01 RID: 31233 RVA: 0x000AFDA0 File Offset: 0x000ADFA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06007A02 RID: 31234
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeRingToPolyData_GetShrinkPercentage_04(HandleRef pThis);

		/// <summary>
		/// Define a shrink percentage for each of the sectors.
		/// </summary>
		// Token: 0x06007A03 RID: 31235 RVA: 0x000AFDBC File Offset: 0x000ADFBC
		public virtual double GetShrinkPercentage()
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_GetShrinkPercentage_04(base.GetCppThis());
		}

		// Token: 0x06007A04 RID: 31236
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeRingToPolyData_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A05 RID: 31237 RVA: 0x000AFDDC File Offset: 0x000ADFDC
		public override int IsA(string type)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06007A06 RID: 31238
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeRingToPolyData_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A07 RID: 31239 RVA: 0x000AFDFC File Offset: 0x000ADFFC
		public new static int IsTypeOf(string type)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_IsTypeOf_06(type);
		}

		// Token: 0x06007A08 RID: 31240
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeRingToPolyData_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A09 RID: 31241 RVA: 0x000AFE18 File Offset: 0x000AE018
		public new vtkTreeRingToPolyData NewInstance()
		{
			vtkTreeRingToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeRingToPolyData.vtkTreeRingToPolyData_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007A0A RID: 31242
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeRingToPolyData_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A0B RID: 31243 RVA: 0x000AFE74 File Offset: 0x000AE074
		public new static vtkTreeRingToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkTreeRingToPolyData vtkTreeRingToPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeRingToPolyData.vtkTreeRingToPolyData_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeRingToPolyData = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeRingToPolyData.Register(null);
				}
			}
			return vtkTreeRingToPolyData;
		}

		// Token: 0x06007A0C RID: 31244
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingToPolyData_SetSectorsArrayName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The field containing quadruples of the form (start angle, end angle,
		/// inner radius, outer radius)
		/// representing the bounds of the rectangles for each vertex.
		/// This field may be added to the tree using vtkTreeRingLayout.
		/// This array must be set.
		/// </summary>
		// Token: 0x06007A0D RID: 31245 RVA: 0x000AFEF3 File Offset: 0x000AE0F3
		public virtual void SetSectorsArrayName(string name)
		{
			vtkTreeRingToPolyData.vtkTreeRingToPolyData_SetSectorsArrayName_10(base.GetCppThis(), name);
		}

		// Token: 0x06007A0E RID: 31246
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingToPolyData_SetShrinkPercentage_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Define a shrink percentage for each of the sectors.
		/// </summary>
		// Token: 0x06007A0F RID: 31247 RVA: 0x000AFF03 File Offset: 0x000AE103
		public virtual void SetShrinkPercentage(double _arg)
		{
			vtkTreeRingToPolyData.vtkTreeRingToPolyData_SetShrinkPercentage_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A5A RID: 2650
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeRingToPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A5B RID: 2651
		public new static readonly string MRClassNameKey = "class vtkTreeRingToPolyData";
	}
}
