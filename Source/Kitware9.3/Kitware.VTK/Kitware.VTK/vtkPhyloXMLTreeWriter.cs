using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPhyloXMLTreeWriter
	/// </summary>
	/// <remarks>
	///    write vtkTree data to PhyloXML format.
	///
	/// vtkPhyloXMLTreeWriter is writes a vtkTree to a PhyloXML formatted file
	/// or string.
	/// </remarks>
	// Token: 0x020001A4 RID: 420
	public class vtkPhyloXMLTreeWriter : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060051C6 RID: 20934 RVA: 0x000771B3 File Offset: 0x000753B3
		static vtkPhyloXMLTreeWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPhyloXMLTreeWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPhyloXMLTreeWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060051C7 RID: 20935 RVA: 0x000771DB File Offset: 0x000753DB
		public vtkPhyloXMLTreeWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060051C8 RID: 20936
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051C9 RID: 20937 RVA: 0x000771EC File Offset: 0x000753EC
		public new static vtkPhyloXMLTreeWriter New()
		{
			vtkPhyloXMLTreeWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPhyloXMLTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051CA RID: 20938 RVA: 0x00077240 File Offset: 0x00075440
		public vtkPhyloXMLTreeWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060051CB RID: 20939 RVA: 0x00077284 File Offset: 0x00075484
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060051CC RID: 20940
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x060051CD RID: 20941 RVA: 0x00077290 File Offset: 0x00075490
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060051CE RID: 20942
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPhyloXMLTreeWriter_GetEdgeWeightArrayName_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the input's tree edge weight array.
		/// This array must be part of the input tree's EdgeData.
		/// The default name is "weight".  If this array cannot be
		/// found, then no edge weights will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x060051CF RID: 20943 RVA: 0x000772CC File Offset: 0x000754CC
		public virtual string GetEdgeWeightArrayName()
		{
			return vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_GetEdgeWeightArrayName_02(base.GetCppThis());
		}

		// Token: 0x060051D0 RID: 20944
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeWriter_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x060051D1 RID: 20945 RVA: 0x000772EC File Offset: 0x000754EC
		public new vtkTree GetInput()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060051D2 RID: 20946
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeWriter_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x060051D3 RID: 20947 RVA: 0x0007735C File Offset: 0x0007555C
		public new vtkTree GetInput(int port)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060051D4 RID: 20948
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPhyloXMLTreeWriter_GetNodeNameArrayName_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the input's tree node name array.
		/// This array must be part of the input tree's VertexData.
		/// The default name is "node name".  If this array cannot
		/// be found, then no node names will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x060051D5 RID: 20949 RVA: 0x000773CC File Offset: 0x000755CC
		public virtual string GetNodeNameArrayName()
		{
			return vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_GetNodeNameArrayName_05(base.GetCppThis());
		}

		// Token: 0x060051D6 RID: 20950
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPhyloXMLTreeWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051D7 RID: 20951 RVA: 0x000773EC File Offset: 0x000755EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060051D8 RID: 20952
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPhyloXMLTreeWriter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051D9 RID: 20953 RVA: 0x0007740C File Offset: 0x0007560C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060051DA RID: 20954
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPhyloXMLTreeWriter_IgnoreArray_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// Do not include name the VertexData array in the PhyloXML output
		/// of this writer.  Call this function once for each array that
		/// you wish to ignore.
		/// </summary>
		// Token: 0x060051DB RID: 20955 RVA: 0x00077426 File Offset: 0x00075626
		public void IgnoreArray(string arrayName)
		{
			vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_IgnoreArray_08(base.GetCppThis(), arrayName);
		}

		// Token: 0x060051DC RID: 20956
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPhyloXMLTreeWriter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051DD RID: 20957 RVA: 0x00077438 File Offset: 0x00075638
		public override int IsA(string type)
		{
			return vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060051DE RID: 20958
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPhyloXMLTreeWriter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051DF RID: 20959 RVA: 0x00077458 File Offset: 0x00075658
		public new static int IsTypeOf(string type)
		{
			return vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_IsTypeOf_10(type);
		}

		// Token: 0x060051E0 RID: 20960
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051E1 RID: 20961 RVA: 0x00077474 File Offset: 0x00075674
		public new vtkPhyloXMLTreeWriter NewInstance()
		{
			vtkPhyloXMLTreeWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPhyloXMLTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060051E2 RID: 20962
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051E3 RID: 20963 RVA: 0x000774D0 File Offset: 0x000756D0
		public new static vtkPhyloXMLTreeWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPhyloXMLTreeWriter vtkPhyloXMLTreeWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPhyloXMLTreeWriter = (vtkPhyloXMLTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPhyloXMLTreeWriter.Register(null);
				}
			}
			return vtkPhyloXMLTreeWriter;
		}

		// Token: 0x060051E4 RID: 20964
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPhyloXMLTreeWriter_SetEdgeWeightArrayName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the input's tree edge weight array.
		/// This array must be part of the input tree's EdgeData.
		/// The default name is "weight".  If this array cannot be
		/// found, then no edge weights will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x060051E5 RID: 20965 RVA: 0x0007754F File Offset: 0x0007574F
		public virtual void SetEdgeWeightArrayName(string _arg)
		{
			vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_SetEdgeWeightArrayName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060051E6 RID: 20966
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPhyloXMLTreeWriter_SetNodeNameArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the input's tree node name array.
		/// This array must be part of the input tree's VertexData.
		/// The default name is "node name".  If this array cannot
		/// be found, then no node names will be included in the
		/// output of this writer.
		/// </summary>
		// Token: 0x060051E7 RID: 20967 RVA: 0x0007755F File Offset: 0x0007575F
		public virtual void SetNodeNameArrayName(string _arg)
		{
			vtkPhyloXMLTreeWriter.vtkPhyloXMLTreeWriter_SetNodeNameArrayName_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007AD RID: 1965
		public new const string MRFullTypeName = "Kitware.VTK.vtkPhyloXMLTreeWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007AE RID: 1966
		public new static readonly string MRClassNameKey = "class vtkPhyloXMLTreeWriter";
	}
}
