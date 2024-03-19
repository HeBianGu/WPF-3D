using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJSONRenderWindowExporter
	/// </summary>
	/// <remarks>
	///    Exports a render window for vtk-js
	///
	/// vtkJSONRenderWindowExporter constructs a scene graph from an input render
	/// window and generates an archive for vtk-js. The traversal of the scene graph
	/// topology is handled by graph elements constructed by vtkVtkJSViewNodeFactory,
	/// the translation from VTK to vtk-js scene elements (renderers, actors,
	/// mappers, etc.) is handled by vtkVtkJSSceneGraphSerializer, and the
	/// transcription of data is handled by vtkArchiver. The latter two classes are
	/// designed to be extensible via inheritance, and derived instances can be used
	/// to modify the vtk-js file format and output mode.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVtkJSSceneGraphSerializer vtkVtkJSViewNodeFactory
	/// </seealso>
	// Token: 0x020001EA RID: 490
	public class vtkJSONRenderWindowExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005D48 RID: 23880 RVA: 0x000873D0 File Offset: 0x000855D0
		static vtkJSONRenderWindowExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJSONRenderWindowExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONRenderWindowExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005D49 RID: 23881 RVA: 0x000873F8 File Offset: 0x000855F8
		public vtkJSONRenderWindowExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005D4A RID: 23882
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONRenderWindowExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D4B RID: 23883 RVA: 0x00087408 File Offset: 0x00085608
		public new static vtkJSONRenderWindowExporter New()
		{
			vtkJSONRenderWindowExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONRenderWindowExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D4C RID: 23884 RVA: 0x0008745C File Offset: 0x0008565C
		public vtkJSONRenderWindowExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005D4D RID: 23885 RVA: 0x000874A0 File Offset: 0x000856A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005D4E RID: 23886
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONRenderWindowExporter_CompactOutputOff_01(HandleRef pThis);

		/// <summary>
		/// Write scene in compact form (default is true).
		/// </summary>
		// Token: 0x06005D4F RID: 23887 RVA: 0x000874AB File Offset: 0x000856AB
		public virtual void CompactOutputOff()
		{
			vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_CompactOutputOff_01(base.GetCppThis());
		}

		// Token: 0x06005D50 RID: 23888
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONRenderWindowExporter_CompactOutputOn_02(HandleRef pThis);

		/// <summary>
		/// Write scene in compact form (default is true).
		/// </summary>
		// Token: 0x06005D51 RID: 23889 RVA: 0x000874BA File Offset: 0x000856BA
		public virtual void CompactOutputOn()
		{
			vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_CompactOutputOn_02(base.GetCppThis());
		}

		// Token: 0x06005D52 RID: 23890
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONRenderWindowExporter_GetArchiver_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the Archiver object
		/// </summary>
		// Token: 0x06005D53 RID: 23891 RVA: 0x000874CC File Offset: 0x000856CC
		public virtual vtkArchiver GetArchiver()
		{
			vtkArchiver vtkArchiver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_GetArchiver_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArchiver = (vtkArchiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArchiver.Register(null);
				}
			}
			return vtkArchiver;
		}

		// Token: 0x06005D54 RID: 23892
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJSONRenderWindowExporter_GetCompactOutput_04(HandleRef pThis);

		/// <summary>
		/// Write scene in compact form (default is true).
		/// </summary>
		// Token: 0x06005D55 RID: 23893 RVA: 0x0008753C File Offset: 0x0008573C
		public virtual bool GetCompactOutput()
		{
			return vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_GetCompactOutput_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06005D56 RID: 23894
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D57 RID: 23895 RVA: 0x00087564 File Offset: 0x00085764
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06005D58 RID: 23896
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D59 RID: 23897 RVA: 0x00087584 File Offset: 0x00085784
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06005D5A RID: 23898
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONRenderWindowExporter_GetSerializer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the Serializer object
		/// </summary>
		// Token: 0x06005D5B RID: 23899 RVA: 0x000875A0 File Offset: 0x000857A0
		public virtual vtkVtkJSSceneGraphSerializer GetSerializer()
		{
			vtkVtkJSSceneGraphSerializer vtkVtkJSSceneGraphSerializer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_GetSerializer_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVtkJSSceneGraphSerializer = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVtkJSSceneGraphSerializer.Register(null);
				}
			}
			return vtkVtkJSSceneGraphSerializer;
		}

		// Token: 0x06005D5C RID: 23900
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONRenderWindowExporter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D5D RID: 23901 RVA: 0x00087610 File Offset: 0x00085810
		public override int IsA(string type)
		{
			return vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06005D5E RID: 23902
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONRenderWindowExporter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D5F RID: 23903 RVA: 0x00087630 File Offset: 0x00085830
		public new static int IsTypeOf(string type)
		{
			return vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_IsTypeOf_09(type);
		}

		// Token: 0x06005D60 RID: 23904
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONRenderWindowExporter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D61 RID: 23905 RVA: 0x0008764C File Offset: 0x0008584C
		public new vtkJSONRenderWindowExporter NewInstance()
		{
			vtkJSONRenderWindowExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONRenderWindowExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005D62 RID: 23906
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONRenderWindowExporter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D63 RID: 23907 RVA: 0x000876A8 File Offset: 0x000858A8
		public new static vtkJSONRenderWindowExporter SafeDownCast(vtkObjectBase o)
		{
			vtkJSONRenderWindowExporter vtkJSONRenderWindowExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJSONRenderWindowExporter = (vtkJSONRenderWindowExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJSONRenderWindowExporter.Register(null);
				}
			}
			return vtkJSONRenderWindowExporter;
		}

		// Token: 0x06005D64 RID: 23908
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONRenderWindowExporter_SetArchiver_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the Archiver object
		/// </summary>
		// Token: 0x06005D65 RID: 23909 RVA: 0x00087728 File Offset: 0x00085928
		public virtual void SetArchiver(vtkArchiver arg0)
		{
			vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_SetArchiver_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005D66 RID: 23910
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONRenderWindowExporter_SetCompactOutput_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Write scene in compact form (default is true).
		/// </summary>
		// Token: 0x06005D67 RID: 23911 RVA: 0x00087757 File Offset: 0x00085957
		public virtual void SetCompactOutput(bool _arg)
		{
			vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_SetCompactOutput_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005D68 RID: 23912
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONRenderWindowExporter_SetSerializer_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the Serializer object
		/// </summary>
		// Token: 0x06005D69 RID: 23913 RVA: 0x00087770 File Offset: 0x00085970
		public virtual void SetSerializer(vtkVtkJSSceneGraphSerializer arg0)
		{
			vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_SetSerializer_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005D6A RID: 23914
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONRenderWindowExporter_WriteData_16(HandleRef pThis);

		/// <summary>
		/// Write scene data.
		/// </summary>
		// Token: 0x06005D6B RID: 23915 RVA: 0x0008779F File Offset: 0x0008599F
		public virtual void WriteData()
		{
			vtkJSONRenderWindowExporter.vtkJSONRenderWindowExporter_WriteData_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400089E RID: 2206
		public new const string MRFullTypeName = "Kitware.VTK.vtkJSONRenderWindowExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400089F RID: 2207
		public new static readonly string MRClassNameKey = "class vtkJSONRenderWindowExporter";
	}
}
