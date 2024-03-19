using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChacoGraphReader
	/// </summary>
	/// <remarks>
	///    Reads chaco graph files.
	///
	///
	/// vtkChacoGraphReader reads in files in the Chaco format into a vtkGraph.
	/// An example is the following
	/// &lt;code&gt;
	/// 10 13
	/// 2 6 10
	/// 1 3
	/// 2 4 8
	/// 3 5
	/// 4 6 10
	/// 1 5 7
	/// 6 8
	/// 3 7 9
	/// 8 10
	/// 1 5 9
	/// &lt;/code&gt;
	/// The first line specifies the number of vertices and edges
	/// in the graph. Each additional line contains the vertices adjacent
	/// to a particular vertex.  In this example, vertex 1 is adjacent to
	/// 2, 6 and 10, vertex 2 is adjacent to 1 and 3, etc.  Since Chaco ids
	/// start at 1 and VTK ids start at 0, the vertex ids in the vtkGraph
	/// will be 1 less than the Chaco ids.
	/// </remarks>
	// Token: 0x02000197 RID: 407
	public class vtkChacoGraphReader : vtkUndirectedGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004FAD RID: 20397 RVA: 0x00073DBC File Offset: 0x00071FBC
		static vtkChacoGraphReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChacoGraphReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChacoGraphReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004FAE RID: 20398 RVA: 0x00073DE4 File Offset: 0x00071FE4
		public vtkChacoGraphReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004FAF RID: 20399
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoGraphReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FB0 RID: 20400 RVA: 0x00073DF4 File Offset: 0x00071FF4
		public new static vtkChacoGraphReader New()
		{
			vtkChacoGraphReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChacoGraphReader.vtkChacoGraphReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoGraphReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FB1 RID: 20401 RVA: 0x00073E48 File Offset: 0x00072048
		public vtkChacoGraphReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChacoGraphReader.vtkChacoGraphReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004FB2 RID: 20402 RVA: 0x00073E8C File Offset: 0x0007208C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004FB3 RID: 20403
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoGraphReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The Chaco file name.
		/// </summary>
		// Token: 0x06004FB4 RID: 20404 RVA: 0x00073E98 File Offset: 0x00072098
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkChacoGraphReader.vtkChacoGraphReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004FB5 RID: 20405
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChacoGraphReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FB6 RID: 20406 RVA: 0x00073ED4 File Offset: 0x000720D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChacoGraphReader.vtkChacoGraphReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06004FB7 RID: 20407
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChacoGraphReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FB8 RID: 20408 RVA: 0x00073EF4 File Offset: 0x000720F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChacoGraphReader.vtkChacoGraphReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06004FB9 RID: 20409
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoGraphReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FBA RID: 20410 RVA: 0x00073F10 File Offset: 0x00072110
		public override int IsA(string type)
		{
			return vtkChacoGraphReader.vtkChacoGraphReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06004FBB RID: 20411
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoGraphReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FBC RID: 20412 RVA: 0x00073F30 File Offset: 0x00072130
		public new static int IsTypeOf(string type)
		{
			return vtkChacoGraphReader.vtkChacoGraphReader_IsTypeOf_05(type);
		}

		// Token: 0x06004FBD RID: 20413
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoGraphReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FBE RID: 20414 RVA: 0x00073F4C File Offset: 0x0007214C
		public new vtkChacoGraphReader NewInstance()
		{
			vtkChacoGraphReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChacoGraphReader.vtkChacoGraphReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoGraphReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004FBF RID: 20415
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoGraphReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FC0 RID: 20416 RVA: 0x00073FA8 File Offset: 0x000721A8
		public new static vtkChacoGraphReader SafeDownCast(vtkObjectBase o)
		{
			vtkChacoGraphReader vtkChacoGraphReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChacoGraphReader.vtkChacoGraphReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChacoGraphReader = (vtkChacoGraphReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChacoGraphReader.Register(null);
				}
			}
			return vtkChacoGraphReader;
		}

		// Token: 0x06004FC1 RID: 20417
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoGraphReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The Chaco file name.
		/// </summary>
		// Token: 0x06004FC2 RID: 20418 RVA: 0x00074027 File Offset: 0x00072227
		public virtual void SetFileName(string _arg)
		{
			vtkChacoGraphReader.vtkChacoGraphReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000791 RID: 1937
		public new const string MRFullTypeName = "Kitware.VTK.vtkChacoGraphReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000792 RID: 1938
		public new static readonly string MRClassNameKey = "class vtkChacoGraphReader";
	}
}
