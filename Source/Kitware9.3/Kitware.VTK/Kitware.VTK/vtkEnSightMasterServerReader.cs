using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnSightMasterServerReader
	/// </summary>
	/// <remarks>
	///    reader for compound EnSight files
	/// </remarks>
	// Token: 0x020001C9 RID: 457
	public class vtkEnSightMasterServerReader : vtkGenericEnSightReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060058BF RID: 22719 RVA: 0x0007FFF7 File Offset: 0x0007E1F7
		static vtkEnSightMasterServerReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightMasterServerReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightMasterServerReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060058C0 RID: 22720 RVA: 0x0008001F File Offset: 0x0007E21F
		public vtkEnSightMasterServerReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060058C1 RID: 22721
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightMasterServerReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058C2 RID: 22722 RVA: 0x00080030 File Offset: 0x0007E230
		public new static vtkEnSightMasterServerReader New()
		{
			vtkEnSightMasterServerReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightMasterServerReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058C3 RID: 22723 RVA: 0x00080084 File Offset: 0x0007E284
		public vtkEnSightMasterServerReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060058C4 RID: 22724 RVA: 0x000800C8 File Offset: 0x0007E2C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060058C5 RID: 22725
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightMasterServerReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Set or get the current piece.
		/// </summary>
		// Token: 0x060058C6 RID: 22726 RVA: 0x000800D4 File Offset: 0x0007E2D4
		public override int CanReadFile(string fname)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x060058C7 RID: 22727
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightMasterServerReader_DetermineFileName_02(HandleRef pThis, int piece);

		/// <summary>
		/// Determine which file should be read for piece
		/// </summary>
		// Token: 0x060058C8 RID: 22728 RVA: 0x000800F4 File Offset: 0x0007E2F4
		public int DetermineFileName(int piece)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_DetermineFileName_02(base.GetCppThis(), piece);
		}

		// Token: 0x060058C9 RID: 22729
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightMasterServerReader_GetCurrentPiece_03(HandleRef pThis);

		/// <summary>
		/// Set or get the current piece.
		/// </summary>
		// Token: 0x060058CA RID: 22730 RVA: 0x00080114 File Offset: 0x0007E314
		public virtual int GetCurrentPiece()
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_GetCurrentPiece_03(base.GetCppThis());
		}

		// Token: 0x060058CB RID: 22731
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightMasterServerReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058CC RID: 22732 RVA: 0x00080134 File Offset: 0x0007E334
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060058CD RID: 22733
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightMasterServerReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058CE RID: 22734 RVA: 0x00080154 File Offset: 0x0007E354
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060058CF RID: 22735
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightMasterServerReader_GetPieceCaseFileName_06(HandleRef pThis);

		/// <summary>
		/// Get the file name that will be read.
		/// </summary>
		// Token: 0x060058D0 RID: 22736 RVA: 0x00080170 File Offset: 0x0007E370
		public virtual string GetPieceCaseFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_GetPieceCaseFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060058D1 RID: 22737
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightMasterServerReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058D2 RID: 22738 RVA: 0x000801AC File Offset: 0x0007E3AC
		public override int IsA(string type)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060058D3 RID: 22739
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightMasterServerReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058D4 RID: 22740 RVA: 0x000801CC File Offset: 0x0007E3CC
		public new static int IsTypeOf(string type)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_IsTypeOf_08(type);
		}

		// Token: 0x060058D5 RID: 22741
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightMasterServerReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058D6 RID: 22742 RVA: 0x000801E8 File Offset: 0x0007E3E8
		public new vtkEnSightMasterServerReader NewInstance()
		{
			vtkEnSightMasterServerReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightMasterServerReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060058D7 RID: 22743
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightMasterServerReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058D8 RID: 22744 RVA: 0x00080244 File Offset: 0x0007E444
		public new static vtkEnSightMasterServerReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightMasterServerReader vtkEnSightMasterServerReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightMasterServerReader = (vtkEnSightMasterServerReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightMasterServerReader.Register(null);
				}
			}
			return vtkEnSightMasterServerReader;
		}

		// Token: 0x060058D9 RID: 22745
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightMasterServerReader_SetCurrentPiece_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set or get the current piece.
		/// </summary>
		// Token: 0x060058DA RID: 22746 RVA: 0x000802C3 File Offset: 0x0007E4C3
		public virtual void SetCurrentPiece(int _arg)
		{
			vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_SetCurrentPiece_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000859 RID: 2137
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightMasterServerReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400085A RID: 2138
		public new static readonly string MRClassNameKey = "class vtkEnSightMasterServerReader";
	}
}
