using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLTFExporter
	/// </summary>
	/// <remarks>
	///    export a scene into GLTF 2.0 format.
	///
	/// vtkGLTFExporter is a concrete subclass of vtkExporter that writes GLTF 2.0
	/// files. It currently only supports a very small subset of what VTK can do
	/// including polygonal meshes with optional vertex colors. Over time the class
	/// can be expanded to support more and more of what VTK renders.
	///
	/// It should be noted that gltf is a format for rendering data. As such
	/// it stores what the VTK scene renders as, not the underlying data. For
	/// example it currently does not support quads or higher sided polygons
	/// although VTK does. As such taking an exported gltf file and then selecting
	/// wireframe in a viewer will give all triangles where VTK's rendering
	/// would correctly draw the original polygons. etc.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExporter
	/// </seealso>
	// Token: 0x020001E7 RID: 487
	public class vtkGLTFExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005CD8 RID: 23768 RVA: 0x00086897 File Offset: 0x00084A97
		static vtkGLTFExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLTFExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005CD9 RID: 23769 RVA: 0x000868BF File Offset: 0x00084ABF
		public vtkGLTFExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005CDA RID: 23770
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CDB RID: 23771 RVA: 0x000868D0 File Offset: 0x00084AD0
		public new static vtkGLTFExporter New()
		{
			vtkGLTFExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFExporter.vtkGLTFExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CDC RID: 23772 RVA: 0x00086924 File Offset: 0x00084B24
		public vtkGLTFExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLTFExporter.vtkGLTFExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005CDD RID: 23773 RVA: 0x00086968 File Offset: 0x00084B68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005CDE RID: 23774
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFExporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of the GLTF file to write.
		/// </summary>
		// Token: 0x06005CDF RID: 23775 RVA: 0x00086974 File Offset: 0x00084B74
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGLTFExporter.vtkGLTFExporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005CE0 RID: 23776
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFExporter_GetInlineData_02(HandleRef pThis);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x06005CE1 RID: 23777 RVA: 0x000869B0 File Offset: 0x00084BB0
		public virtual bool GetInlineData()
		{
			return vtkGLTFExporter.vtkGLTFExporter_GetInlineData_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06005CE2 RID: 23778
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFExporter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CE3 RID: 23779 RVA: 0x000869D8 File Offset: 0x00084BD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLTFExporter.vtkGLTFExporter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06005CE4 RID: 23780
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFExporter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CE5 RID: 23781 RVA: 0x000869F8 File Offset: 0x00084BF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLTFExporter.vtkGLTFExporter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06005CE6 RID: 23782
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFExporter_GetSaveBatchId_05(HandleRef pThis);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x06005CE7 RID: 23783 RVA: 0x00086A14 File Offset: 0x00084C14
		public virtual bool GetSaveBatchId()
		{
			return vtkGLTFExporter.vtkGLTFExporter_GetSaveBatchId_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06005CE8 RID: 23784
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFExporter_GetSaveNormal_06(HandleRef pThis);

		/// <summary>
		/// It looks for a point array called
		/// NORMAL in the data and it saves it in the
		/// GLTF file if found.
		/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06005CE9 RID: 23785 RVA: 0x00086A3C File Offset: 0x00084C3C
		public virtual bool GetSaveNormal()
		{
			return vtkGLTFExporter.vtkGLTFExporter_GetSaveNormal_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06005CEA RID: 23786
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_InlineDataOff_07(HandleRef pThis);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x06005CEB RID: 23787 RVA: 0x00086A62 File Offset: 0x00084C62
		public virtual void InlineDataOff()
		{
			vtkGLTFExporter.vtkGLTFExporter_InlineDataOff_07(base.GetCppThis());
		}

		// Token: 0x06005CEC RID: 23788
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_InlineDataOn_08(HandleRef pThis);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x06005CED RID: 23789 RVA: 0x00086A71 File Offset: 0x00084C71
		public virtual void InlineDataOn()
		{
			vtkGLTFExporter.vtkGLTFExporter_InlineDataOn_08(base.GetCppThis());
		}

		// Token: 0x06005CEE RID: 23790
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFExporter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CEF RID: 23791 RVA: 0x00086A80 File Offset: 0x00084C80
		public override int IsA(string type)
		{
			return vtkGLTFExporter.vtkGLTFExporter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06005CF0 RID: 23792
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFExporter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CF1 RID: 23793 RVA: 0x00086AA0 File Offset: 0x00084CA0
		public new static int IsTypeOf(string type)
		{
			return vtkGLTFExporter.vtkGLTFExporter_IsTypeOf_10(type);
		}

		// Token: 0x06005CF2 RID: 23794
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFExporter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CF3 RID: 23795 RVA: 0x00086ABC File Offset: 0x00084CBC
		public new vtkGLTFExporter NewInstance()
		{
			vtkGLTFExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFExporter.vtkGLTFExporter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005CF4 RID: 23796
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFExporter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CF5 RID: 23797 RVA: 0x00086B18 File Offset: 0x00084D18
		public new static vtkGLTFExporter SafeDownCast(vtkObjectBase o)
		{
			vtkGLTFExporter vtkGLTFExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFExporter.vtkGLTFExporter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLTFExporter = (vtkGLTFExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLTFExporter.Register(null);
				}
			}
			return vtkGLTFExporter;
		}

		// Token: 0x06005CF6 RID: 23798
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SaveBatchIdOff_14(HandleRef pThis);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x06005CF7 RID: 23799 RVA: 0x00086B97 File Offset: 0x00084D97
		public virtual void SaveBatchIdOff()
		{
			vtkGLTFExporter.vtkGLTFExporter_SaveBatchIdOff_14(base.GetCppThis());
		}

		// Token: 0x06005CF8 RID: 23800
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SaveBatchIdOn_15(HandleRef pThis);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x06005CF9 RID: 23801 RVA: 0x00086BA6 File Offset: 0x00084DA6
		public virtual void SaveBatchIdOn()
		{
			vtkGLTFExporter.vtkGLTFExporter_SaveBatchIdOn_15(base.GetCppThis());
		}

		// Token: 0x06005CFA RID: 23802
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SaveNormalOff_16(HandleRef pThis);

		/// <summary>
		/// It looks for a point array called
		/// NORMAL in the data and it saves it in the
		/// GLTF file if found.
		/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06005CFB RID: 23803 RVA: 0x00086BB5 File Offset: 0x00084DB5
		public virtual void SaveNormalOff()
		{
			vtkGLTFExporter.vtkGLTFExporter_SaveNormalOff_16(base.GetCppThis());
		}

		// Token: 0x06005CFC RID: 23804
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SaveNormalOn_17(HandleRef pThis);

		/// <summary>
		/// It looks for a point array called
		/// NORMAL in the data and it saves it in the
		/// GLTF file if found.
		/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06005CFD RID: 23805 RVA: 0x00086BC4 File Offset: 0x00084DC4
		public virtual void SaveNormalOn()
		{
			vtkGLTFExporter.vtkGLTFExporter_SaveNormalOn_17(base.GetCppThis());
		}

		// Token: 0x06005CFE RID: 23806
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SetFileName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the GLTF file to write.
		/// </summary>
		// Token: 0x06005CFF RID: 23807 RVA: 0x00086BD3 File Offset: 0x00084DD3
		public virtual void SetFileName(string _arg)
		{
			vtkGLTFExporter.vtkGLTFExporter_SetFileName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06005D00 RID: 23808
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SetInlineData_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x06005D01 RID: 23809 RVA: 0x00086BE3 File Offset: 0x00084DE3
		public virtual void SetInlineData(bool _arg)
		{
			vtkGLTFExporter.vtkGLTFExporter_SetInlineData_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005D02 RID: 23810
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SetSaveBatchId_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x06005D03 RID: 23811 RVA: 0x00086BFB File Offset: 0x00084DFB
		public virtual void SetSaveBatchId(bool _arg)
		{
			vtkGLTFExporter.vtkGLTFExporter_SetSaveBatchId_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005D04 RID: 23812
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFExporter_SetSaveNormal_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// It looks for a point array called
		/// NORMAL in the data and it saves it in the
		/// GLTF file if found.
		/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06005D05 RID: 23813 RVA: 0x00086C13 File Offset: 0x00084E13
		public virtual void SetSaveNormal(bool _arg)
		{
			vtkGLTFExporter.vtkGLTFExporter_SetSaveNormal_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005D06 RID: 23814
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkGLTFExporter_WriteToString_22(HandleRef pThis);

		/// <summary>
		/// Write the result to a string instead of a file
		/// </summary>
		// Token: 0x06005D07 RID: 23815 RVA: 0x00086C2C File Offset: 0x00084E2C
		public string WriteToString()
		{
			return vtkGLTFExporter.vtkGLTFExporter_WriteToString_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000898 RID: 2200
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000899 RID: 2201
		public new static readonly string MRClassNameKey = "class vtkGLTFExporter";
	}
}
