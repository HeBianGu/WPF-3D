using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVtkJSSceneGraphSerializer
	/// </summary>
	/// <remarks>
	///    Converts elements of a VTK scene graph into vtk-js elements
	///
	/// vtkVtkJSSceneGraphSerializer accepts nodes and their renderables from a scene
	/// graph and a) composes the elements' data and topology into a Json data
	/// structure and b) correlates unique identifiers for data objects in the Json
	/// data structure to the data objects themselves. It is designed to operate with
	/// vtkVtkJSViewNodeFactory, which handles the logic for scene graph traversal.
	///
	/// When constructing the Json description for a single scene graph node and its
	/// renderable, the Add(node, renderable) step processes the renderable into its
	/// corresponding vtk-js form. For many renderables this is a no-op, but current
	/// restrictions in vtk-js (such as the lack of support for composite mappers and
	/// the requirement for data conversion to vtkPolyData) require a nontrival
	/// conversion step for certain renderable types. The subsequent
	/// ToJson(renderable) is a straightforward conversion of the renderable's data
	/// members into a vtk-js Json format.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVtkJSViewNodeFactory
	/// </seealso>
	// Token: 0x020001F7 RID: 503
	public class vtkVtkJSSceneGraphSerializer : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060060EC RID: 24812 RVA: 0x0008B885 File Offset: 0x00089A85
		static vtkVtkJSSceneGraphSerializer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVtkJSSceneGraphSerializer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVtkJSSceneGraphSerializer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060060ED RID: 24813 RVA: 0x0008B8AD File Offset: 0x00089AAD
		public vtkVtkJSSceneGraphSerializer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060060EE RID: 24814
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSSceneGraphSerializer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060EF RID: 24815 RVA: 0x0008B8BC File Offset: 0x00089ABC
		public new static vtkVtkJSSceneGraphSerializer New()
		{
			vtkVtkJSSceneGraphSerializer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060F0 RID: 24816 RVA: 0x0008B910 File Offset: 0x00089B10
		public vtkVtkJSSceneGraphSerializer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060060F1 RID: 24817 RVA: 0x0008B954 File Offset: 0x00089B54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060060F2 RID: 24818
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSSceneGraphSerializer_Add_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Add a scene graph node and its corresponding renderable to the scene.
		/// </summary>
		// Token: 0x060060F3 RID: 24819 RVA: 0x0008B960 File Offset: 0x00089B60
		public virtual void Add(vtkViewNode arg0, vtkActor arg1)
		{
			vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_Add_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060060F4 RID: 24820
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSSceneGraphSerializer_Add_02(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Add a scene graph node and its corresponding renderable to the scene.
		/// </summary>
		// Token: 0x060060F5 RID: 24821 RVA: 0x0008B9A4 File Offset: 0x00089BA4
		public virtual void Add(vtkViewNode arg0, vtkCompositePolyDataMapper arg1)
		{
			vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_Add_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060060F6 RID: 24822
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSSceneGraphSerializer_Add_03(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Add a scene graph node and its corresponding renderable to the scene.
		/// </summary>
		// Token: 0x060060F7 RID: 24823 RVA: 0x0008B9E8 File Offset: 0x00089BE8
		public virtual void Add(vtkViewNode arg0, vtkGlyph3DMapper arg1)
		{
			vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_Add_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060060F8 RID: 24824
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSSceneGraphSerializer_Add_04(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Add a scene graph node and its corresponding renderable to the scene.
		/// </summary>
		// Token: 0x060060F9 RID: 24825 RVA: 0x0008BA2C File Offset: 0x00089C2C
		public virtual void Add(vtkViewNode arg0, vtkMapper arg1)
		{
			vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_Add_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060060FA RID: 24826
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSSceneGraphSerializer_Add_05(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Add a scene graph node and its corresponding renderable to the scene.
		/// </summary>
		// Token: 0x060060FB RID: 24827 RVA: 0x0008BA70 File Offset: 0x00089C70
		public virtual void Add(vtkViewNode arg0, vtkRenderer arg1)
		{
			vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_Add_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060060FC RID: 24828
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSSceneGraphSerializer_Add_06(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Add a scene graph node and its corresponding renderable to the scene.
		/// </summary>
		// Token: 0x060060FD RID: 24829 RVA: 0x0008BAB4 File Offset: 0x00089CB4
		public virtual void Add(vtkViewNode arg0, vtkRenderWindow arg1)
		{
			vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_Add_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060060FE RID: 24830
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSSceneGraphSerializer_GetDataArray_07(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the data arrays referenced in the constructed scene.
		/// </summary>
		// Token: 0x060060FF RID: 24831 RVA: 0x0008BAF8 File Offset: 0x00089CF8
		public vtkDataArray GetDataArray(long arg0)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetDataArray_07(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x06006100 RID: 24832
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkVtkJSSceneGraphSerializer_GetDataArrayId_08(HandleRef pThis, long arg0);

		/// <summary>
		/// Access the data arrays referenced in the constructed scene.
		/// </summary>
		// Token: 0x06006101 RID: 24833 RVA: 0x0008BB68 File Offset: 0x00089D68
		public string GetDataArrayId(long arg0)
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetDataArrayId_08(base.GetCppThis(), arg0);
		}

		// Token: 0x06006102 RID: 24834
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSSceneGraphSerializer_GetDataObject_09(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the data objects referenced in the constructed scene.
		/// </summary>
		// Token: 0x06006103 RID: 24835 RVA: 0x0008BB88 File Offset: 0x00089D88
		public vtkDataObject GetDataObject(long arg0)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetDataObject_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06006104 RID: 24836
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVtkJSSceneGraphSerializer_GetDataObjectId_10(HandleRef pThis, long arg0);

		/// <summary>
		/// Access the data objects referenced in the constructed scene.
		/// </summary>
		// Token: 0x06006105 RID: 24837 RVA: 0x0008BBF8 File Offset: 0x00089DF8
		public uint GetDataObjectId(long arg0)
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetDataObjectId_10(base.GetCppThis(), arg0);
		}

		// Token: 0x06006106 RID: 24838
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfDataArrays_11(HandleRef pThis);

		/// <summary>
		/// Access the data arrays referenced in the constructed scene.
		/// </summary>
		// Token: 0x06006107 RID: 24839 RVA: 0x0008BC18 File Offset: 0x00089E18
		public long GetNumberOfDataArrays()
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetNumberOfDataArrays_11(base.GetCppThis());
		}

		// Token: 0x06006108 RID: 24840
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfDataObjects_12(HandleRef pThis);

		/// <summary>
		/// Access the data objects referenced in the constructed scene.
		/// </summary>
		// Token: 0x06006109 RID: 24841 RVA: 0x0008BC38 File Offset: 0x00089E38
		public long GetNumberOfDataObjects()
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetNumberOfDataObjects_12(base.GetCppThis());
		}

		// Token: 0x0600610A RID: 24842
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600610B RID: 24843 RVA: 0x0008BC58 File Offset: 0x00089E58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600610C RID: 24844
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600610D RID: 24845 RVA: 0x0008BC78 File Offset: 0x00089E78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600610E RID: 24846
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVtkJSSceneGraphSerializer_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600610F RID: 24847 RVA: 0x0008BC94 File Offset: 0x00089E94
		public override int IsA(string type)
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06006110 RID: 24848
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVtkJSSceneGraphSerializer_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006111 RID: 24849 RVA: 0x0008BCB4 File Offset: 0x00089EB4
		public new static int IsTypeOf(string type)
		{
			return vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_IsTypeOf_16(type);
		}

		// Token: 0x06006112 RID: 24850
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSSceneGraphSerializer_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006113 RID: 24851 RVA: 0x0008BCD0 File Offset: 0x00089ED0
		public new vtkVtkJSSceneGraphSerializer NewInstance()
		{
			vtkVtkJSSceneGraphSerializer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006114 RID: 24852
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSSceneGraphSerializer_Reset_19(HandleRef pThis);

		/// <summary>
		/// Empty the contents of the scene and the reset the unique id generator.
		/// </summary>
		// Token: 0x06006115 RID: 24853 RVA: 0x0008BD2A File Offset: 0x00089F2A
		public void Reset()
		{
			vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_Reset_19(base.GetCppThis());
		}

		// Token: 0x06006116 RID: 24854
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSSceneGraphSerializer_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006117 RID: 24855 RVA: 0x0008BD3C File Offset: 0x00089F3C
		public new static vtkVtkJSSceneGraphSerializer SafeDownCast(vtkObjectBase o)
		{
			vtkVtkJSSceneGraphSerializer vtkVtkJSSceneGraphSerializer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSSceneGraphSerializer.vtkVtkJSSceneGraphSerializer_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B8 RID: 2232
		public new const string MRFullTypeName = "Kitware.VTK.vtkVtkJSSceneGraphSerializer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B9 RID: 2233
		public new static readonly string MRClassNameKey = "class vtkVtkJSSceneGraphSerializer";
	}
}
