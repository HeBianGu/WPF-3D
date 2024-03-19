using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiNewickTreeReader
	/// </summary>
	/// <remarks>
	///    read multiple vtkTrees from Newick formatted file
	///
	/// vtkMultiNewickTreeReader is a source object that reads Newick tree format
	/// files.
	/// The output of this reader is a single vtkMultiPieceDataSet that contains multiple vtkTree
	/// objects. The superclass of this class, vtkDataReader, provides many methods for controlling the
	/// reading of the data file, see vtkDataReader for more information.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTree vtkDataReader
	/// </seealso>
	// Token: 0x0200019E RID: 414
	public class vtkMultiNewickTreeReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060050F5 RID: 20725 RVA: 0x00075A17 File Offset: 0x00073C17
		static vtkMultiNewickTreeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiNewickTreeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiNewickTreeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060050F6 RID: 20726 RVA: 0x00075A3F File Offset: 0x00073C3F
		public vtkMultiNewickTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060050F7 RID: 20727
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiNewickTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050F8 RID: 20728 RVA: 0x00075A50 File Offset: 0x00073C50
		public new static vtkMultiNewickTreeReader New()
		{
			vtkMultiNewickTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiNewickTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050F9 RID: 20729 RVA: 0x00075AA4 File Offset: 0x00073CA4
		public vtkMultiNewickTreeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060050FA RID: 20730 RVA: 0x00075AE8 File Offset: 0x00073CE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060050FB RID: 20731
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050FC RID: 20732 RVA: 0x00075AF4 File Offset: 0x00073CF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060050FD RID: 20733
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050FE RID: 20734 RVA: 0x00075B14 File Offset: 0x00073D14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060050FF RID: 20735
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiNewickTreeReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06005100 RID: 20736 RVA: 0x00075B30 File Offset: 0x00073D30
		public vtkMultiPieceDataSet GetOutput()
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		// Token: 0x06005101 RID: 20737
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiNewickTreeReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06005102 RID: 20738 RVA: 0x00075BA0 File Offset: 0x00073DA0
		public vtkMultiPieceDataSet GetOutput(int idx)
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		// Token: 0x06005103 RID: 20739
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiNewickTreeReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005104 RID: 20740 RVA: 0x00075C10 File Offset: 0x00073E10
		public override int IsA(string type)
		{
			return vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06005105 RID: 20741
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiNewickTreeReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005106 RID: 20742 RVA: 0x00075C30 File Offset: 0x00073E30
		public new static int IsTypeOf(string type)
		{
			return vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_IsTypeOf_06(type);
		}

		// Token: 0x06005107 RID: 20743
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiNewickTreeReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005108 RID: 20744 RVA: 0x00075C4C File Offset: 0x00073E4C
		public new vtkMultiNewickTreeReader NewInstance()
		{
			vtkMultiNewickTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiNewickTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005109 RID: 20745
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiNewickTreeReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x0600510A RID: 20746 RVA: 0x00075CA8 File Offset: 0x00073EA8
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600510B RID: 20747
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiNewickTreeReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600510C RID: 20748 RVA: 0x00075CE0 File Offset: 0x00073EE0
		public new static vtkMultiNewickTreeReader SafeDownCast(vtkObjectBase o)
		{
			vtkMultiNewickTreeReader vtkMultiNewickTreeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiNewickTreeReader = (vtkMultiNewickTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiNewickTreeReader.Register(null);
				}
			}
			return vtkMultiNewickTreeReader;
		}

		// Token: 0x0600510D RID: 20749
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiNewickTreeReader_SetOutput_11(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x0600510E RID: 20750 RVA: 0x00075D60 File Offset: 0x00073F60
		public void SetOutput(vtkMultiPieceDataSet output)
		{
			vtkMultiNewickTreeReader.vtkMultiNewickTreeReader_SetOutput_11(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400079F RID: 1951
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiNewickTreeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007A0 RID: 1952
		public new static readonly string MRClassNameKey = "class vtkMultiNewickTreeReader";
	}
}
