using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoxLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a tree map layout that puts vertices in square-ish boxes
	///
	///
	/// vtkBoxLayoutStrategy recursively partitions the space for children vertices
	/// in a tree-map into square regions (or regions very close to a square).
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie from Sandia National Laboratories for creating this class.
	/// </remarks>
	// Token: 0x02000281 RID: 641
	public class vtkBoxLayoutStrategy : vtkTreeMapLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007441 RID: 29761 RVA: 0x000A804F File Offset: 0x000A624F
		static vtkBoxLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007442 RID: 29762 RVA: 0x000A8077 File Offset: 0x000A6277
		public vtkBoxLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007443 RID: 29763
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007444 RID: 29764 RVA: 0x000A8088 File Offset: 0x000A6288
		public new static vtkBoxLayoutStrategy New()
		{
			vtkBoxLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007445 RID: 29765 RVA: 0x000A80DC File Offset: 0x000A62DC
		public vtkBoxLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007446 RID: 29766 RVA: 0x000A8120 File Offset: 0x000A6320
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007447 RID: 29767
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007448 RID: 29768 RVA: 0x000A812C File Offset: 0x000A632C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007449 RID: 29769
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxLayoutStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600744A RID: 29770 RVA: 0x000A814C File Offset: 0x000A634C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600744B RID: 29771
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxLayoutStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600744C RID: 29772 RVA: 0x000A8168 File Offset: 0x000A6368
		public override int IsA(string type)
		{
			return vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600744D RID: 29773
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxLayoutStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600744E RID: 29774 RVA: 0x000A8188 File Offset: 0x000A6388
		public new static int IsTypeOf(string type)
		{
			return vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_IsTypeOf_04(type);
		}

		// Token: 0x0600744F RID: 29775
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxLayoutStrategy_Layout_05(HandleRef pThis, HandleRef inputTree, HandleRef coordsArray, HandleRef sizeArray);

		/// <summary>
		/// Perform the layout of a tree and place the results as 4-tuples in
		/// coordsArray (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x06007450 RID: 29776 RVA: 0x000A81A4 File Offset: 0x000A63A4
		public override void Layout(vtkTree inputTree, vtkDataArray coordsArray, vtkDataArray sizeArray)
		{
			vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_Layout_05(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (coordsArray == null) ? default(HandleRef) : coordsArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		// Token: 0x06007451 RID: 29777
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxLayoutStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007452 RID: 29778 RVA: 0x000A8200 File Offset: 0x000A6400
		public new vtkBoxLayoutStrategy NewInstance()
		{
			vtkBoxLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007453 RID: 29779
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxLayoutStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007454 RID: 29780 RVA: 0x000A825C File Offset: 0x000A645C
		public new static vtkBoxLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkBoxLayoutStrategy vtkBoxLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxLayoutStrategy = (vtkBoxLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxLayoutStrategy.Register(null);
				}
			}
			return vtkBoxLayoutStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A10 RID: 2576
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A11 RID: 2577
		public new static readonly string MRClassNameKey = "class vtkBoxLayoutStrategy";
	}
}
