using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNewickTreeReader
	/// </summary>
	/// <remarks>
	///    read vtkTree from Newick formatted file
	///
	/// vtkNewickTreeReader is a source object that reads Newick tree format
	/// files.
	/// The output of this reader is a single vtkTree data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @par Thanks:
	/// This class is adapted from code originally written by Yu-Wei Wu.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTree vtkDataReader
	/// </seealso>
	// Token: 0x0200019F RID: 415
	public class vtkNewickTreeReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600510F RID: 20751 RVA: 0x00075D8F File Offset: 0x00073F8F
		static vtkNewickTreeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNewickTreeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNewickTreeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005110 RID: 20752 RVA: 0x00075DB7 File Offset: 0x00073FB7
		public vtkNewickTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005111 RID: 20753
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005112 RID: 20754 RVA: 0x00075DC8 File Offset: 0x00073FC8
		public new static vtkNewickTreeReader New()
		{
			vtkNewickTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeReader.vtkNewickTreeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNewickTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005113 RID: 20755 RVA: 0x00075E1C File Offset: 0x0007401C
		public vtkNewickTreeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNewickTreeReader.vtkNewickTreeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005114 RID: 20756 RVA: 0x00075E60 File Offset: 0x00074060
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005115 RID: 20757
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNewickTreeReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005116 RID: 20758 RVA: 0x00075E6C File Offset: 0x0007406C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNewickTreeReader.vtkNewickTreeReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005117 RID: 20759
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNewickTreeReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005118 RID: 20760 RVA: 0x00075E8C File Offset: 0x0007408C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNewickTreeReader.vtkNewickTreeReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005119 RID: 20761
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x0600511A RID: 20762 RVA: 0x00075EA8 File Offset: 0x000740A8
		public vtkTree GetOutput()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeReader.vtkNewickTreeReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x0600511B RID: 20763
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x0600511C RID: 20764 RVA: 0x00075F18 File Offset: 0x00074118
		public vtkTree GetOutput(int idx)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeReader.vtkNewickTreeReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x0600511D RID: 20765
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNewickTreeReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600511E RID: 20766 RVA: 0x00075F88 File Offset: 0x00074188
		public override int IsA(string type)
		{
			return vtkNewickTreeReader.vtkNewickTreeReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600511F RID: 20767
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNewickTreeReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005120 RID: 20768 RVA: 0x00075FA8 File Offset: 0x000741A8
		public new static int IsTypeOf(string type)
		{
			return vtkNewickTreeReader.vtkNewickTreeReader_IsTypeOf_06(type);
		}

		// Token: 0x06005121 RID: 20769
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005122 RID: 20770 RVA: 0x00075FC4 File Offset: 0x000741C4
		public new vtkNewickTreeReader NewInstance()
		{
			vtkNewickTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeReader.vtkNewickTreeReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNewickTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005123 RID: 20771
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNewickTreeReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06005124 RID: 20772 RVA: 0x00076020 File Offset: 0x00074220
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkNewickTreeReader.vtkNewickTreeReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06005125 RID: 20773
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNewickTreeReader_ReadNewickTree_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string buffer, vtkTree tree);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06005126 RID: 20774 RVA: 0x00076058 File Offset: 0x00074258
		public int ReadNewickTree(string buffer, vtkTree tree)
		{
			return vtkNewickTreeReader.vtkNewickTreeReader_ReadNewickTree_10(base.GetCppThis(), buffer, tree);
		}

		// Token: 0x06005127 RID: 20775
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005128 RID: 20776 RVA: 0x0007607C File Offset: 0x0007427C
		public new static vtkNewickTreeReader SafeDownCast(vtkObjectBase o)
		{
			vtkNewickTreeReader vtkNewickTreeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeReader.vtkNewickTreeReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNewickTreeReader = (vtkNewickTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNewickTreeReader.Register(null);
				}
			}
			return vtkNewickTreeReader;
		}

		// Token: 0x06005129 RID: 20777
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNewickTreeReader_SetOutput_12(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x0600512A RID: 20778 RVA: 0x000760FC File Offset: 0x000742FC
		public void SetOutput(vtkTree output)
		{
			vtkNewickTreeReader.vtkNewickTreeReader_SetOutput_12(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007A1 RID: 1953
		public new const string MRFullTypeName = "Kitware.VTK.vtkNewickTreeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007A2 RID: 1954
		public new static readonly string MRClassNameKey = "class vtkNewickTreeReader";
	}
}
