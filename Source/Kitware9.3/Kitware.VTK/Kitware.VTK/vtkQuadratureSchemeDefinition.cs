using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadratureSchemeDefinition
	///
	/// An Elemental data type that holds a definition of a
	/// numerical quadrature scheme. The definition contains
	/// the requisite information to interpolate to the so called
	/// quadrature points of the specific scheme. namely:
	///
	/// &lt;pre&gt;
	/// 1)
	/// A matrix of shape function weights(shape functions evaluated
	/// at parametric coordinates of the quadrature points).
	///
	/// 2)
	/// The number of quadrature points and cell nodes. These parameters
	/// size the matrix, and allow for convenient evaluation by users
	/// of the definition.
	/// &lt;/pre&gt;
	/// </summary>
	// Token: 0x02000AB5 RID: 2741
	public class vtkQuadratureSchemeDefinition : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CD7C RID: 118140 RVA: 0x00289E19 File Offset: 0x00288019
		static vtkQuadratureSchemeDefinition()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadratureSchemeDefinition.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadratureSchemeDefinition"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CD7D RID: 118141 RVA: 0x00289E41 File Offset: 0x00288041
		public vtkQuadratureSchemeDefinition(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CD7E RID: 118142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// New object in an unusable state. You'll have to call
		/// "Initilaize" to get the definition in to a usable state.
		/// </summary>
		// Token: 0x0601CD7F RID: 118143 RVA: 0x00289E50 File Offset: 0x00288050
		public new static vtkQuadratureSchemeDefinition New()
		{
			vtkQuadratureSchemeDefinition result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// New object in an unusable state. You'll have to call
		/// "Initilaize" to get the definition in to a usable state.
		/// </summary>
		// Token: 0x0601CD80 RID: 118144 RVA: 0x00289EA4 File Offset: 0x002880A4
		public vtkQuadratureSchemeDefinition() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CD81 RID: 118145 RVA: 0x00289EE8 File Offset: 0x002880E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CD82 RID: 118146
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadratureSchemeDefinition_Clear_01(HandleRef pThis);

		/// <summary>
		/// Release all allocated resources and set the
		/// object to an uninitialized state.
		/// </summary>
		// Token: 0x0601CD83 RID: 118147 RVA: 0x00289EF3 File Offset: 0x002880F3
		public void Clear()
		{
			vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_Clear_01(base.GetCppThis());
		}

		// Token: 0x0601CD84 RID: 118148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_DICTIONARY_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD85 RID: 118149 RVA: 0x00289F04 File Offset: 0x00288104
		public static vtkInformationQuadratureSchemeDefinitionVectorKey DICTIONARY()
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey vtkInformationQuadratureSchemeDefinitionVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_DICTIONARY_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationQuadratureSchemeDefinitionVectorKey = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationQuadratureSchemeDefinitionVectorKey.Register(null);
				}
			}
			return vtkInformationQuadratureSchemeDefinitionVectorKey;
		}

		// Token: 0x0601CD86 RID: 118150
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_DeepCopy_03(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Deep copy.
		/// </summary>
		// Token: 0x0601CD87 RID: 118151 RVA: 0x00289F70 File Offset: 0x00288170
		public int DeepCopy(vtkQuadratureSchemeDefinition other)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_DeepCopy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601CD88 RID: 118152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_GetCellType_04(HandleRef pThis);

		/// <summary>
		/// Access the VTK cell type id.
		/// </summary>
		// Token: 0x0601CD89 RID: 118153 RVA: 0x00289FA4 File Offset: 0x002881A4
		public int GetCellType()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetCellType_04(base.GetCppThis());
		}

		// Token: 0x0601CD8A RID: 118154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD8B RID: 118155 RVA: 0x00289FC4 File Offset: 0x002881C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601CD8C RID: 118156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD8D RID: 118157 RVA: 0x00289FE4 File Offset: 0x002881E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601CD8E RID: 118158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_GetNumberOfNodes_07(HandleRef pThis);

		/// <summary>
		/// Get the number of nodes associated with the interpolation.
		/// </summary>
		// Token: 0x0601CD8F RID: 118159 RVA: 0x0028A000 File Offset: 0x00288200
		public int GetNumberOfNodes()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetNumberOfNodes_07(base.GetCppThis());
		}

		// Token: 0x0601CD90 RID: 118160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_GetNumberOfQuadraturePoints_08(HandleRef pThis);

		/// <summary>
		/// Get the number of quadrature points associated with the scheme.
		/// </summary>
		// Token: 0x0601CD91 RID: 118161 RVA: 0x0028A020 File Offset: 0x00288220
		public int GetNumberOfQuadraturePoints()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetNumberOfQuadraturePoints_08(base.GetCppThis());
		}

		// Token: 0x0601CD92 RID: 118162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_GetQuadratureKey_09(HandleRef pThis);

		/// <summary>
		/// Access to an alternative key.
		/// </summary>
		// Token: 0x0601CD93 RID: 118163 RVA: 0x0028A040 File Offset: 0x00288240
		public int GetQuadratureKey()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetQuadratureKey_09(base.GetCppThis());
		}

		// Token: 0x0601CD94 RID: 118164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_GetQuadratureWeights_10(HandleRef pThis);

		/// <summary>
		/// Access to the quadrature weights.
		/// </summary>
		// Token: 0x0601CD95 RID: 118165 RVA: 0x0028A060 File Offset: 0x00288260
		public IntPtr GetQuadratureWeights()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetQuadratureWeights_10(base.GetCppThis());
		}

		// Token: 0x0601CD96 RID: 118166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_11(HandleRef pThis);

		/// <summary>
		/// Get the array of shape function weights. Shape function weights are
		/// the shape functions evaluated at the quadrature points. There are
		/// "NumberOfNodes" weights for each quadrature point.
		/// </summary>
		// Token: 0x0601CD97 RID: 118167 RVA: 0x0028A080 File Offset: 0x00288280
		public IntPtr GetShapeFunctionWeights()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_11(base.GetCppThis());
		}

		// Token: 0x0601CD98 RID: 118168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_12(HandleRef pThis, int quadraturePointId);

		/// <summary>
		/// Get the array of shape function weights associated with a
		/// single quadrature point.
		/// </summary>
		// Token: 0x0601CD99 RID: 118169 RVA: 0x0028A0A0 File Offset: 0x002882A0
		public IntPtr GetShapeFunctionWeights(int quadraturePointId)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_12(base.GetCppThis(), quadraturePointId);
		}

		// Token: 0x0601CD9A RID: 118170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadratureSchemeDefinition_Initialize_13(HandleRef pThis, int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights);

		/// <summary>
		/// Initialize the object allocating resources as needed.
		/// </summary>
		// Token: 0x0601CD9B RID: 118171 RVA: 0x0028A0C0 File Offset: 0x002882C0
		public void Initialize(int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights)
		{
			vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_Initialize_13(base.GetCppThis(), cellType, numberOfNodes, numberOfQuadraturePoints, shapeFunctionWeights);
		}

		// Token: 0x0601CD9C RID: 118172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadratureSchemeDefinition_Initialize_14(HandleRef pThis, int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights, IntPtr quadratureWeights);

		/// <summary>
		/// Initialize the object allocating resources as needed.
		/// </summary>
		// Token: 0x0601CD9D RID: 118173 RVA: 0x0028A0D4 File Offset: 0x002882D4
		public void Initialize(int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights, IntPtr quadratureWeights)
		{
			vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_Initialize_14(base.GetCppThis(), cellType, numberOfNodes, numberOfQuadraturePoints, shapeFunctionWeights, quadratureWeights);
		}

		// Token: 0x0601CD9E RID: 118174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD9F RID: 118175 RVA: 0x0028A0EC File Offset: 0x002882EC
		public override int IsA(string type)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0601CDA0 RID: 118176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDA1 RID: 118177 RVA: 0x0028A10C File Offset: 0x0028830C
		public new static int IsTypeOf(string type)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_IsTypeOf_16(type);
		}

		// Token: 0x0601CDA2 RID: 118178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDA3 RID: 118179 RVA: 0x0028A128 File Offset: 0x00288328
		public new vtkQuadratureSchemeDefinition NewInstance()
		{
			vtkQuadratureSchemeDefinition result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CDA4 RID: 118180
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_QUADRATURE_OFFSET_ARRAY_NAME_19(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDA5 RID: 118181 RVA: 0x0028A184 File Offset: 0x00288384
		public static vtkInformationStringKey QUADRATURE_OFFSET_ARRAY_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_QUADRATURE_OFFSET_ARRAY_NAME_19(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x0601CDA6 RID: 118182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_RestoreState_20(HandleRef pThis, HandleRef root);

		/// <summary>
		/// Restore the object from an XML representation.
		/// </summary>
		// Token: 0x0601CDA7 RID: 118183 RVA: 0x0028A1F0 File Offset: 0x002883F0
		public int RestoreState(vtkXMLDataElement root)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_RestoreState_20(base.GetCppThis(), (root == null) ? default(HandleRef) : root.GetCppThis());
		}

		// Token: 0x0601CDA8 RID: 118184
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDA9 RID: 118185 RVA: 0x0028A224 File Offset: 0x00288424
		public new static vtkQuadratureSchemeDefinition SafeDownCast(vtkObjectBase o)
		{
			vtkQuadratureSchemeDefinition vtkQuadratureSchemeDefinition = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadratureSchemeDefinition = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadratureSchemeDefinition.Register(null);
				}
			}
			return vtkQuadratureSchemeDefinition;
		}

		// Token: 0x0601CDAA RID: 118186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDefinition_SaveState_22(HandleRef pThis, HandleRef root);

		/// <summary>
		/// Put the object into an XML representation. The element
		/// passed in is assumed to be empty.
		/// </summary>
		// Token: 0x0601CDAB RID: 118187 RVA: 0x0028A2A4 File Offset: 0x002884A4
		public int SaveState(vtkXMLDataElement root)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_SaveState_22(base.GetCppThis(), (root == null) ? default(HandleRef) : root.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E73 RID: 7795
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadratureSchemeDefinition";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E74 RID: 7796
		public new static readonly string MRClassNameKey = "class vtkQuadratureSchemeDefinition";
	}
}
