using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractUserDefinedPiece
	/// </summary>
	/// <remarks>
	///    Return user specified piece with ghost cells
	///
	///
	/// Provided a function that determines which cells are zero-level
	/// cells ("the piece"), this class outputs the piece with the
	/// requested number of ghost levels.  The only difference between
	/// this class and the class it is derived from is that the
	/// zero-level cells are specified by a function you provide,
	/// instead of determined by dividing up the cells based on cell Id.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractUnstructuredGridPiece
	/// </seealso>
	// Token: 0x02000503 RID: 1283
	public class vtkExtractUserDefinedPiece : vtkExtractUnstructuredGridPiece
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E6D6 RID: 59094 RVA: 0x00141807 File Offset: 0x0013FA07
		static vtkExtractUserDefinedPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractUserDefinedPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUserDefinedPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6D7 RID: 59095 RVA: 0x0014182F File Offset: 0x0013FA2F
		public vtkExtractUserDefinedPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E6D8 RID: 59096
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUserDefinedPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6D9 RID: 59097 RVA: 0x00141840 File Offset: 0x0013FA40
		public new static vtkExtractUserDefinedPiece New()
		{
			vtkExtractUserDefinedPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6DA RID: 59098 RVA: 0x00141894 File Offset: 0x0013FA94
		public vtkExtractUserDefinedPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6DB RID: 59099 RVA: 0x001418D8 File Offset: 0x0013FAD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E6DC RID: 59100
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6DD RID: 59101 RVA: 0x001418E4 File Offset: 0x0013FAE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E6DE RID: 59102
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6DF RID: 59103 RVA: 0x00141904 File Offset: 0x0013FB04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E6E0 RID: 59104
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUserDefinedPiece_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6E1 RID: 59105 RVA: 0x00141920 File Offset: 0x0013FB20
		public override int IsA(string type)
		{
			return vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E6E2 RID: 59106
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUserDefinedPiece_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6E3 RID: 59107 RVA: 0x00141940 File Offset: 0x0013FB40
		public new static int IsTypeOf(string type)
		{
			return vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_IsTypeOf_04(type);
		}

		// Token: 0x0600E6E4 RID: 59108
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUserDefinedPiece_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6E5 RID: 59109 RVA: 0x0014195C File Offset: 0x0013FB5C
		public new vtkExtractUserDefinedPiece NewInstance()
		{
			vtkExtractUserDefinedPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E6E6 RID: 59110
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUserDefinedPiece_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6E7 RID: 59111 RVA: 0x001419B8 File Offset: 0x0013FBB8
		public new static vtkExtractUserDefinedPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractUserDefinedPiece vtkExtractUserDefinedPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractUserDefinedPiece = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractUserDefinedPiece.Register(null);
				}
			}
			return vtkExtractUserDefinedPiece;
		}

		// Token: 0x0600E6E8 RID: 59112
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUserDefinedPiece_SetConstantData_08(HandleRef pThis, IntPtr data, int len);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6E9 RID: 59113 RVA: 0x00141A37 File Offset: 0x0013FC37
		public void SetConstantData(IntPtr data, int len)
		{
			vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_SetConstantData_08(base.GetCppThis(), data, len);
		}

		// Token: 0x0600E6EA RID: 59114
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUserDefinedPiece_SetPieceFunction_09(HandleRef pThis, vtkExtractUserDefinedPiece.UserDefFunc func);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6EB RID: 59115 RVA: 0x00141A48 File Offset: 0x0013FC48
		public void SetPieceFunction(vtkExtractUserDefinedPiece.UserDefFunc func)
		{
			vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_SetPieceFunction_09(base.GetCppThis(), func);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010EF RID: 4335
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUserDefinedPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F0 RID: 4336
		public new static readonly string MRClassNameKey = "class vtkExtractUserDefinedPiece";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000504 RID: 1284
		// (Invoke) Token: 0x0600E6ED RID: 59117
		public delegate int UserDefFunc(long arg0, IntPtr arg1, IntPtr arg2);
	}
}
