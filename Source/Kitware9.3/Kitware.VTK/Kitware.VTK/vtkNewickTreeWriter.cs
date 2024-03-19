using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNewickTreeWriter
	/// </summary>
	/// <remarks>
	///    write vtkTree data to Newick format.
	///
	/// vtkNewickTreeWriter is writes a vtkTree to a Newick formatted file
	/// or string.
	/// </remarks>
	// Token: 0x020001A0 RID: 416
	public class vtkNewickTreeWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600512B RID: 20779 RVA: 0x0007612B File Offset: 0x0007432B
		static vtkNewickTreeWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNewickTreeWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNewickTreeWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600512C RID: 20780 RVA: 0x00076153 File Offset: 0x00074353
		public vtkNewickTreeWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600512D RID: 20781
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600512E RID: 20782 RVA: 0x00076164 File Offset: 0x00074364
		public new static vtkNewickTreeWriter New()
		{
			vtkNewickTreeWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeWriter.vtkNewickTreeWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNewickTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600512F RID: 20783 RVA: 0x000761B8 File Offset: 0x000743B8
		public vtkNewickTreeWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNewickTreeWriter.vtkNewickTreeWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005130 RID: 20784 RVA: 0x000761FC File Offset: 0x000743FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005131 RID: 20785
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNewickTreeWriter_GetEdgeWeightArrayName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the input's tree edge weight array.
		/// This array must be part of the input tree's EdgeData.
		/// The default name is "weight".  If this array cannot be
		/// found, then no edge weights will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x06005132 RID: 20786 RVA: 0x00076208 File Offset: 0x00074408
		public virtual string GetEdgeWeightArrayName()
		{
			return vtkNewickTreeWriter.vtkNewickTreeWriter_GetEdgeWeightArrayName_01(base.GetCppThis());
		}

		// Token: 0x06005133 RID: 20787
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06005134 RID: 20788 RVA: 0x00076228 File Offset: 0x00074428
		public new vtkTree GetInput()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeWriter.vtkNewickTreeWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005135 RID: 20789
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeWriter_GetInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06005136 RID: 20790 RVA: 0x00076298 File Offset: 0x00074498
		public new vtkTree GetInput(int port)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeWriter.vtkNewickTreeWriter_GetInput_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005137 RID: 20791
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNewickTreeWriter_GetNodeNameArrayName_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the input's tree node name array.
		/// This array must be part of the input tree's VertexData.
		/// The default name is "node name".  If this array cannot
		/// be found, then no node names will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x06005138 RID: 20792 RVA: 0x00076308 File Offset: 0x00074508
		public virtual string GetNodeNameArrayName()
		{
			return vtkNewickTreeWriter.vtkNewickTreeWriter_GetNodeNameArrayName_04(base.GetCppThis());
		}

		// Token: 0x06005139 RID: 20793
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNewickTreeWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600513A RID: 20794 RVA: 0x00076328 File Offset: 0x00074528
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNewickTreeWriter.vtkNewickTreeWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600513B RID: 20795
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNewickTreeWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600513C RID: 20796 RVA: 0x00076348 File Offset: 0x00074548
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNewickTreeWriter.vtkNewickTreeWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600513D RID: 20797
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNewickTreeWriter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600513E RID: 20798 RVA: 0x00076364 File Offset: 0x00074564
		public override int IsA(string type)
		{
			return vtkNewickTreeWriter.vtkNewickTreeWriter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600513F RID: 20799
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNewickTreeWriter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005140 RID: 20800 RVA: 0x00076384 File Offset: 0x00074584
		public new static int IsTypeOf(string type)
		{
			return vtkNewickTreeWriter.vtkNewickTreeWriter_IsTypeOf_08(type);
		}

		// Token: 0x06005141 RID: 20801
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005142 RID: 20802 RVA: 0x000763A0 File Offset: 0x000745A0
		public new vtkNewickTreeWriter NewInstance()
		{
			vtkNewickTreeWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeWriter.vtkNewickTreeWriter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNewickTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005143 RID: 20803
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNewickTreeWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005144 RID: 20804 RVA: 0x000763FC File Offset: 0x000745FC
		public new static vtkNewickTreeWriter SafeDownCast(vtkObjectBase o)
		{
			vtkNewickTreeWriter vtkNewickTreeWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNewickTreeWriter.vtkNewickTreeWriter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNewickTreeWriter = (vtkNewickTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNewickTreeWriter.Register(null);
				}
			}
			return vtkNewickTreeWriter;
		}

		// Token: 0x06005145 RID: 20805
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNewickTreeWriter_SetEdgeWeightArrayName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the input's tree edge weight array.
		/// This array must be part of the input tree's EdgeData.
		/// The default name is "weight".  If this array cannot be
		/// found, then no edge weights will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x06005146 RID: 20806 RVA: 0x0007647B File Offset: 0x0007467B
		public virtual void SetEdgeWeightArrayName(string _arg)
		{
			vtkNewickTreeWriter.vtkNewickTreeWriter_SetEdgeWeightArrayName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06005147 RID: 20807
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNewickTreeWriter_SetNodeNameArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the input's tree node name array.
		/// This array must be part of the input tree's VertexData.
		/// The default name is "node name".  If this array cannot
		/// be found, then no node names will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x06005148 RID: 20808 RVA: 0x0007648B File Offset: 0x0007468B
		public virtual void SetNodeNameArrayName(string _arg)
		{
			vtkNewickTreeWriter.vtkNewickTreeWriter_SetNodeNameArrayName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007A3 RID: 1955
		public new const string MRFullTypeName = "Kitware.VTK.vtkNewickTreeWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007A4 RID: 1956
		public new static readonly string MRClassNameKey = "class vtkNewickTreeWriter";
	}
}
