using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSliceAndDiceLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a horizontal and vertical slicing tree map layout
	///
	///
	/// Lays out a tree-map alternating between horizontal and vertical slices,
	/// taking into account the relative size of each vertex.
	///
	/// @par Thanks:
	/// Slice and dice algorithm comes from:
	/// Shneiderman, B. 1992. Tree visualization with tree-maps: 2-d space-filling approach.
	/// ACM Trans. Graph. 11, 1 (Jan. 1992), 92-99.
	/// </remarks>
	// Token: 0x0200029B RID: 667
	public class vtkSliceAndDiceLayoutStrategy : vtkTreeMapLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060078B2 RID: 30898 RVA: 0x000ADE85 File Offset: 0x000AC085
		static vtkSliceAndDiceLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliceAndDiceLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliceAndDiceLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060078B3 RID: 30899 RVA: 0x000ADEAD File Offset: 0x000AC0AD
		public vtkSliceAndDiceLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060078B4 RID: 30900
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceAndDiceLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078B5 RID: 30901 RVA: 0x000ADEBC File Offset: 0x000AC0BC
		public new static vtkSliceAndDiceLayoutStrategy New()
		{
			vtkSliceAndDiceLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceAndDiceLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078B6 RID: 30902 RVA: 0x000ADF10 File Offset: 0x000AC110
		public vtkSliceAndDiceLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060078B7 RID: 30903 RVA: 0x000ADF54 File Offset: 0x000AC154
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060078B8 RID: 30904
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliceAndDiceLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078B9 RID: 30905 RVA: 0x000ADF60 File Offset: 0x000AC160
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060078BA RID: 30906
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliceAndDiceLayoutStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078BB RID: 30907 RVA: 0x000ADF80 File Offset: 0x000AC180
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060078BC RID: 30908
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliceAndDiceLayoutStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078BD RID: 30909 RVA: 0x000ADF9C File Offset: 0x000AC19C
		public override int IsA(string type)
		{
			return vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060078BE RID: 30910
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliceAndDiceLayoutStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078BF RID: 30911 RVA: 0x000ADFBC File Offset: 0x000AC1BC
		public new static int IsTypeOf(string type)
		{
			return vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_IsTypeOf_04(type);
		}

		// Token: 0x060078C0 RID: 30912
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliceAndDiceLayoutStrategy_Layout_05(HandleRef pThis, HandleRef inputTree, HandleRef coordsArray, HandleRef sizeArray);

		/// <summary>
		/// Perform the layout of a tree and place the results as 4-tuples in
		/// coordsArray (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x060078C1 RID: 30913 RVA: 0x000ADFD8 File Offset: 0x000AC1D8
		public override void Layout(vtkTree inputTree, vtkDataArray coordsArray, vtkDataArray sizeArray)
		{
			vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_Layout_05(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (coordsArray == null) ? default(HandleRef) : coordsArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		// Token: 0x060078C2 RID: 30914
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceAndDiceLayoutStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078C3 RID: 30915 RVA: 0x000AE034 File Offset: 0x000AC234
		public new vtkSliceAndDiceLayoutStrategy NewInstance()
		{
			vtkSliceAndDiceLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceAndDiceLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060078C4 RID: 30916
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceAndDiceLayoutStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078C5 RID: 30917 RVA: 0x000AE090 File Offset: 0x000AC290
		public new static vtkSliceAndDiceLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSliceAndDiceLayoutStrategy vtkSliceAndDiceLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliceAndDiceLayoutStrategy = (vtkSliceAndDiceLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliceAndDiceLayoutStrategy.Register(null);
				}
			}
			return vtkSliceAndDiceLayoutStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A45 RID: 2629
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliceAndDiceLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A46 RID: 2630
		public new static readonly string MRClassNameKey = "class vtkSliceAndDiceLayoutStrategy";
	}
}
