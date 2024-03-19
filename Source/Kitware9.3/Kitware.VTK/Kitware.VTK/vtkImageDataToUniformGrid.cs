using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDataToUniformGrid
	/// </summary>
	/// <remarks>
	///    convert vtkImageData to vtkUniformGrid
	///
	/// Convert a vtkImageData to vtkUniformGrid and set blanking based on
	/// specified by named arrays. By default, values of 0 in the named
	/// array will result in the point or cell being blanked. Set Reverse
	/// to 1 to indicate that values of 0 will result in the point or
	/// cell to not be blanked.
	/// </remarks>
	// Token: 0x0200090D RID: 2317
	public class vtkImageDataToUniformGrid : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018062 RID: 98402 RVA: 0x00219D0F File Offset: 0x00217F0F
		static vtkImageDataToUniformGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataToUniformGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataToUniformGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018063 RID: 98403 RVA: 0x00219D37 File Offset: 0x00217F37
		public vtkImageDataToUniformGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018064 RID: 98404
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToUniformGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018065 RID: 98405 RVA: 0x00219D48 File Offset: 0x00217F48
		public new static vtkImageDataToUniformGrid New()
		{
			vtkImageDataToUniformGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataToUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018066 RID: 98406 RVA: 0x00219D9C File Offset: 0x00217F9C
		public vtkImageDataToUniformGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018067 RID: 98407 RVA: 0x00219DE0 File Offset: 0x00217FE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018068 RID: 98408
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018069 RID: 98409 RVA: 0x00219DEC File Offset: 0x00217FEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601806A RID: 98410
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601806B RID: 98411 RVA: 0x00219E0C File Offset: 0x0021800C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601806C RID: 98412
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToUniformGrid_GetReverse_03(HandleRef pThis);

		/// <summary>
		/// By default, values of 0 (i.e. Reverse = 0) in the array will
		/// result in that point or cell to be blanked. Set Reverse to
		/// 1 to make points or cells to not be blanked for array values
		/// of 0.
		/// </summary>
		// Token: 0x0601806D RID: 98413 RVA: 0x00219E28 File Offset: 0x00218028
		public virtual int GetReverse()
		{
			return vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_GetReverse_03(base.GetCppThis());
		}

		// Token: 0x0601806E RID: 98414
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToUniformGrid_GetReverseMaxValue_04(HandleRef pThis);

		/// <summary>
		/// By default, values of 0 (i.e. Reverse = 0) in the array will
		/// result in that point or cell to be blanked. Set Reverse to
		/// 1 to make points or cells to not be blanked for array values
		/// of 0.
		/// </summary>
		// Token: 0x0601806F RID: 98415 RVA: 0x00219E48 File Offset: 0x00218048
		public virtual int GetReverseMaxValue()
		{
			return vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_GetReverseMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06018070 RID: 98416
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToUniformGrid_GetReverseMinValue_05(HandleRef pThis);

		/// <summary>
		/// By default, values of 0 (i.e. Reverse = 0) in the array will
		/// result in that point or cell to be blanked. Set Reverse to
		/// 1 to make points or cells to not be blanked for array values
		/// of 0.
		/// </summary>
		// Token: 0x06018071 RID: 98417 RVA: 0x00219E68 File Offset: 0x00218068
		public virtual int GetReverseMinValue()
		{
			return vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_GetReverseMinValue_05(base.GetCppThis());
		}

		// Token: 0x06018072 RID: 98418
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToUniformGrid_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018073 RID: 98419 RVA: 0x00219E88 File Offset: 0x00218088
		public override int IsA(string type)
		{
			return vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06018074 RID: 98420
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToUniformGrid_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018075 RID: 98421 RVA: 0x00219EA8 File Offset: 0x002180A8
		public new static int IsTypeOf(string type)
		{
			return vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_IsTypeOf_07(type);
		}

		// Token: 0x06018076 RID: 98422
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToUniformGrid_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018077 RID: 98423 RVA: 0x00219EC4 File Offset: 0x002180C4
		public new vtkImageDataToUniformGrid NewInstance()
		{
			vtkImageDataToUniformGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataToUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018078 RID: 98424
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataToUniformGrid_ReverseOff_10(HandleRef pThis);

		/// <summary>
		/// By default, values of 0 (i.e. Reverse = 0) in the array will
		/// result in that point or cell to be blanked. Set Reverse to
		/// 1 to make points or cells to not be blanked for array values
		/// of 0.
		/// </summary>
		// Token: 0x06018079 RID: 98425 RVA: 0x00219F1E File Offset: 0x0021811E
		public virtual void ReverseOff()
		{
			vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_ReverseOff_10(base.GetCppThis());
		}

		// Token: 0x0601807A RID: 98426
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataToUniformGrid_ReverseOn_11(HandleRef pThis);

		/// <summary>
		/// By default, values of 0 (i.e. Reverse = 0) in the array will
		/// result in that point or cell to be blanked. Set Reverse to
		/// 1 to make points or cells to not be blanked for array values
		/// of 0.
		/// </summary>
		// Token: 0x0601807B RID: 98427 RVA: 0x00219F2D File Offset: 0x0021812D
		public virtual void ReverseOn()
		{
			vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_ReverseOn_11(base.GetCppThis());
		}

		// Token: 0x0601807C RID: 98428
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToUniformGrid_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601807D RID: 98429 RVA: 0x00219F3C File Offset: 0x0021813C
		public new static vtkImageDataToUniformGrid SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataToUniformGrid vtkImageDataToUniformGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataToUniformGrid = (vtkImageDataToUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataToUniformGrid.Register(null);
				}
			}
			return vtkImageDataToUniformGrid;
		}

		// Token: 0x0601807E RID: 98430
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataToUniformGrid_SetReverse_13(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, values of 0 (i.e. Reverse = 0) in the array will
		/// result in that point or cell to be blanked. Set Reverse to
		/// 1 to make points or cells to not be blanked for array values
		/// of 0.
		/// </summary>
		// Token: 0x0601807F RID: 98431 RVA: 0x00219FBB File Offset: 0x002181BB
		public virtual void SetReverse(int _arg)
		{
			vtkImageDataToUniformGrid.vtkImageDataToUniformGrid_SetReverse_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC4 RID: 6852
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataToUniformGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC5 RID: 6853
		public new static readonly string MRClassNameKey = "class vtkImageDataToUniformGrid";
	}
}
