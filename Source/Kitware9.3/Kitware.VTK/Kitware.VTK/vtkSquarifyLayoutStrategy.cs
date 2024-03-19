using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSquarifyLayoutStrategy
	/// </summary>
	/// <remarks>
	///    uses the squarify tree map layout algorithm
	///
	///
	/// vtkSquarifyLayoutStrategy partitions the space for child vertices into regions
	/// that use all available space and are as close to squares as possible.
	/// The algorithm also takes into account the relative vertex size.
	///
	/// @par Thanks:
	/// The squarified tree map algorithm comes from:
	/// Bruls, D.M., C. Huizing, J.J. van Wijk. Squarified Treemaps.
	/// In: W. de Leeuw, R. van Liere (eds.), Data Visualization 2000,
	/// Proceedings of the joint Eurographics and IEEE TCVG Symposium on Visualization,
	/// 2000, Springer, Vienna, p. 33-42.
	/// </remarks>
	// Token: 0x0200029F RID: 671
	public class vtkSquarifyLayoutStrategy : vtkTreeMapLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007900 RID: 30976 RVA: 0x000AE6DF File Offset: 0x000AC8DF
		static vtkSquarifyLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSquarifyLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSquarifyLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007901 RID: 30977 RVA: 0x000AE707 File Offset: 0x000AC907
		public vtkSquarifyLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007902 RID: 30978
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSquarifyLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007903 RID: 30979 RVA: 0x000AE718 File Offset: 0x000AC918
		public new static vtkSquarifyLayoutStrategy New()
		{
			vtkSquarifyLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSquarifyLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007904 RID: 30980 RVA: 0x000AE76C File Offset: 0x000AC96C
		public vtkSquarifyLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007905 RID: 30981 RVA: 0x000AE7B0 File Offset: 0x000AC9B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007906 RID: 30982
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSquarifyLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007907 RID: 30983 RVA: 0x000AE7BC File Offset: 0x000AC9BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007908 RID: 30984
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSquarifyLayoutStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007909 RID: 30985 RVA: 0x000AE7DC File Offset: 0x000AC9DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600790A RID: 30986
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSquarifyLayoutStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600790B RID: 30987 RVA: 0x000AE7F8 File Offset: 0x000AC9F8
		public override int IsA(string type)
		{
			return vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600790C RID: 30988
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSquarifyLayoutStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600790D RID: 30989 RVA: 0x000AE818 File Offset: 0x000ACA18
		public new static int IsTypeOf(string type)
		{
			return vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_IsTypeOf_04(type);
		}

		// Token: 0x0600790E RID: 30990
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSquarifyLayoutStrategy_Layout_05(HandleRef pThis, HandleRef inputTree, HandleRef coordsArray, HandleRef sizeArray);

		/// <summary>
		/// Perform the layout of a tree and place the results as 4-tuples in
		/// coordsArray (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x0600790F RID: 30991 RVA: 0x000AE834 File Offset: 0x000ACA34
		public override void Layout(vtkTree inputTree, vtkDataArray coordsArray, vtkDataArray sizeArray)
		{
			vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_Layout_05(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (coordsArray == null) ? default(HandleRef) : coordsArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		// Token: 0x06007910 RID: 30992
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSquarifyLayoutStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007911 RID: 30993 RVA: 0x000AE890 File Offset: 0x000ACA90
		public new vtkSquarifyLayoutStrategy NewInstance()
		{
			vtkSquarifyLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSquarifyLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007912 RID: 30994
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSquarifyLayoutStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007913 RID: 30995 RVA: 0x000AE8EC File Offset: 0x000ACAEC
		public new static vtkSquarifyLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSquarifyLayoutStrategy vtkSquarifyLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSquarifyLayoutStrategy = (vtkSquarifyLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSquarifyLayoutStrategy.Register(null);
				}
			}
			return vtkSquarifyLayoutStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A4E RID: 2638
		public new const string MRFullTypeName = "Kitware.VTK.vtkSquarifyLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A4F RID: 2639
		public new static readonly string MRClassNameKey = "class vtkSquarifyLayoutStrategy";
	}
}
